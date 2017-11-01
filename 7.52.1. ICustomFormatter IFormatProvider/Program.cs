/*
Quote from
Accelerated C# 2005
# By Trey Nash
# ISBN: 1-59059-717-6
# 432 pp.
# Published: Aug 2006
*/

using System;
using System.Text;
using System.Globalization;
using System.Threading;

public class ComplexDbgFormatter : ICustomFormatter, IFormatProvider
{
    public object GetFormat(Type formatType)
    {
        if (formatType == typeof(ICustomFormatter))
        {
            return this;
        }
        else
        {
            return CultureInfo.CurrentCulture.
                GetFormat(formatType);
        }
    }

    public string Format(string format, object arg, IFormatProvider formatProvider)
    {
        if (arg.GetType() == typeof(Complex) && format == "DBG")
        {
            Complex cpx = (Complex)arg;

            StringBuilder sb = new StringBuilder();
            sb.Append(arg.GetType().ToString() + " ");
            sb.AppendFormat("Real:{0} ", cpx.Real);
            sb.AppendFormat("Img: {0} ", cpx.Img);
            return sb.ToString();
        }
        else
        {
            IFormattable formatable = arg as IFormattable;
            if (formatable != null)
            {
                return formatable.ToString(format, formatProvider);
            }
            else
            {
                return arg.ToString();
            }
        }
    }
}

public struct Complex : IFormattable
{
    public Complex(double Real, double Img)
    {
        this.Real = Real;
        this.Img = Img;
    }

    public string ToString(string format, IFormatProvider formatProvider)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("( " + Real.ToString(format, formatProvider));
        sb.Append(" : " + Img.ToString(format, formatProvider));
        sb.Append(" )");

        return sb.ToString();
    }

    public double Real;
    public double Img;
}

public class MainClass
{
    static void Main()
    {
        /**/

        double value = 1634.92;
        CultureInfo.CurrentCulture = new CultureInfo("fr-CA");
        Console.WriteLine("Current Culture: {0}",
                          CultureInfo.CurrentCulture.Name);
        Console.WriteLine("{0:C2}\n", value);

        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr");
        Console.WriteLine("Current Culture: {0}",
                          CultureInfo.CurrentCulture.Name);
        Console.WriteLine("{0:C2}", value);
        /**/


        CultureInfo local = CultureInfo.CurrentCulture;
        CultureInfo germany = new CultureInfo("de-DE");

        Complex cpx = new Complex(12.3456, 1234.56);

        string strCpx = cpx.ToString("F", local);
        Console.WriteLine(strCpx);

        strCpx = cpx.ToString("F", germany);
        Console.WriteLine(strCpx);

        ComplexDbgFormatter dbgFormatter = new ComplexDbgFormatter();
        strCpx = String.Format(dbgFormatter, "{0:DBG}", cpx);
        Console.WriteLine("\nDebugging output:\n{0}", strCpx);
    }
}
//( 12.35 : 1234.56 )
//( 12,35 : 1234,56 )

//Debugging output:
//Complex Real:12.3456 Img: 1234.56
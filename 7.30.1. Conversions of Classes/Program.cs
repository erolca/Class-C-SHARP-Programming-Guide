using System;


//	7.30.1.	Conversions of Classes (Reference Types) to an Interface the Object Might Implement


interface Printable
{
    string Print();
}

class NonPrintablePaper
{
    public NonPrintablePaper(int value)
    {
        this.value = value;
    }
    public override string ToString()
    {
        return (value.ToString());
    }
    int value;
}


class PrintablePaper : Printable
{
    public PrintablePaper(string name)
    {
        this.name = name;
    }
    public override string ToString()
    {
        return (name);
    }
    string Printable.Print()
    {
        return ("print...");
    }
    string name;
}



class MainClass
{
    public static void TryPrinting(params object[] arr)
    {
        foreach (object o in arr)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/as
            Printable printableObject = o as Printable; 
            if (printableObject != null)
                Console.WriteLine("{0}", printableObject.Print());
            else
                Console.WriteLine("{0}", o);
        }
    }
    static void Main()
    {
        NonPrintablePaper d = new NonPrintablePaper(13);
        PrintablePaper c = new PrintablePaper("Tracking Test");
        TryPrinting(d, c);






        // as tutorial
        object[] objArray = new object[6];
        objArray[0] = new ClassA();
        objArray[1] = new ClassB();
        objArray[2] = "hello";
        objArray[3] = 123;
        objArray[4] = 123.4;
        objArray[5] = null;

        for (int i = 0; i < objArray.Length; ++i)
        {
            string s = objArray[i] as string;
            Console.Write("{0}:", i);
            if (s != null)
            {
                Console.WriteLine("'" + s + "'");
            }
            else
            {
                Console.WriteLine("not a string");
            }
        }
    }
}

class ClassA { }
class ClassB { }
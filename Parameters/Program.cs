#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{

    class WrappedInt
    {
        public int Number;
    }

    class Pass
    {
        public static void Value(ref int param)
        {
            param = 42;
        }

        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
    }



    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(ref i);
            Console.WriteLine(i);

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
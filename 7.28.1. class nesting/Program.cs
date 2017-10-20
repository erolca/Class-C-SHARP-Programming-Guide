using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Outer
{
    private static int state;

    internal class Inner
    {
        void Foo()
        {
            state++;
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {

        Outer t1 = new Outer();
        Outer.Inner t2 = new Outer.Inner();
        
        
        }
    }


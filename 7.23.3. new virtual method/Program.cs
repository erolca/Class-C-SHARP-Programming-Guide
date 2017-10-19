using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Control
{
    public virtual void Foo() { }
}
class MyControl : Control
{
    // not an override
    public new virtual void Foo() { }
}



    class Program
    {
        static void Main(string[] args)
        {
        }
    }


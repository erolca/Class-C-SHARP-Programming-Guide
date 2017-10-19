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
    // an override for Control.Foo()
    public override void Foo() { }
}


    class Program
    {
        static void Main(string[] args)
        {
        }
    }


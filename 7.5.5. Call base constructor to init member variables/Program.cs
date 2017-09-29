using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class A
{
    public A(int x)
    {
        this.x = x;
    }

    public A() : this(0)
    {
    }

    internal int x;
}

public class B : A
{
    public B() : base(1)
    {
    }

}

public class MainClass
{
    static void Main()
    {
        B b = new B();
        System.Console.WriteLine("A.x = {0}", b.x);
    }
}
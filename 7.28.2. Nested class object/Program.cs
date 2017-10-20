using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class A
{
    public class B
    {
    }
}

public class MainClass
{
    static void Main()
    {
        A.B b = new A.B();
    }
}
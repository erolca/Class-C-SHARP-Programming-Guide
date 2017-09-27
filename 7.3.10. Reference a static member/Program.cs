using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//7.3.10.	Reference a static member function without using the class name

public class A
{
    public static void SomeFunction()
    {
        System.Console.WriteLine("SomeFunction() called");
    }

    static void Main()
    {
        A.SomeFunction();
        SomeFunction();
    }
}
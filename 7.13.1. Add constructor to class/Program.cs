using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
A constructor initializes an object when it is created.
A constructor has the same name as its class
A constructor is syntactically similar to a method.
Constructors have no explicit return type.

The general form of constructor is shown here:

access class-name( )
{
  // constructor code
}

You can use a constructor to give initial values to the instance variables

 */

class MyClass
{
    public int x;

    //constructor
    public MyClass()
    {
        x = 10;
    }

}

class ConsDemo
{
    public static void Main()
    {
        MyClass t1 = new MyClass();
        MyClass t2 = new MyClass();
        Console.WriteLine(t1.x + " " + t2.x);
    }
}
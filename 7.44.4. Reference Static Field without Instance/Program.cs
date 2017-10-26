using System;

class MyClass
{
    static public int myStaticValue;
}

class Program
{
    static void Main()
    {
        MyClass.myStaticValue = 5;
        Console.WriteLine("myStaticValue = {0}", MyClass.myStaticValue);
    }
}
//myStaticValue = 5
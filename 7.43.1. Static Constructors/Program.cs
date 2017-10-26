using System;

class MyClass
{
    static MyClass()
    {
        Console.WriteLine("MyClass is initializing");
    }
    public static int I;
}

class MainClass
{
    public static void Main()
    {
        MyClass.I = 1;
    }
}

//MyClass is initializing
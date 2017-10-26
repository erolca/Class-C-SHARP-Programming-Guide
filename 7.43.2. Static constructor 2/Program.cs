using System;

class MyClass
{
    private static Random RandomKey;

    static MyClass()
    {
        RandomKey = new Random();
    }

    public int GetValue()
    {
        return RandomKey.Next();
    }
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass();
        MyClass b = new MyClass();
        Console.WriteLine("Next Random #: {0}", a.GetValue());
        Console.WriteLine("Next Random #: {0}", b.GetValue());
    }
}
//Next Random #: 1768997546
//Next Random #: 1565321362
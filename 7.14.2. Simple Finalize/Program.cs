using System;

class MyClass
{
    ~MyClass()
    {
        Console.WriteLine("Finalizing");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        MyClass fc = new MyClass();
        Console.WriteLine("Exiting main");
    }
}

//Exiting main
//Finalizing
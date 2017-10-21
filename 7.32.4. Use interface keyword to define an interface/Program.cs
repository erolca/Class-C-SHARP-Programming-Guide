using System;

interface Interface1
{
    void PrintOut(string s);
}

class MyClass : Interface1
{
    public void PrintOut(string s)
    {
        Console.WriteLine("Calling through: {0}", s);
    }
}

class MainClass
{
    static void Main()
    {
        MyClass mc = new MyClass();
        mc.PrintOut("object.");
    }
}
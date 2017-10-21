using System;

interface Interface1
{
    void PrintOut(string s);
}

interface Interface2
{
    void PrintOut(string t);
}

class MyClass : Interface1, Interface2
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

//Calling through: object.
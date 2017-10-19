using System;


interface Interface1
{
    void PrintOut(string s);
}

class BaseClass
{
    public void PrintOut(string s)
    {
        Console.WriteLine("Calling through: {0}", s);
    }
}

class Derived : BaseClass, Interface1
{
}

class MainClass
{
    static void Main()
    {
        Derived d = new Derived();
        d.PrintOut("object.");
    }
}
//Calling through: object.
using System;

class BaseClass
{
    public string Field1 = "In the base class";
}

class DerivedClass : BaseClass
{
    new public string Field1 = "In the derived class";

    public void Display()
    {
        Console.WriteLine("{0}", Field1);              // Access the derived class.
        Console.WriteLine("{0}", base.Field1);         // Access the base class.
    }
}

class Program
{
    static void Main()
    {
        DerivedClass oc = new DerivedClass();
        oc.Display();
    }
}

//In the derived class
//In the base class
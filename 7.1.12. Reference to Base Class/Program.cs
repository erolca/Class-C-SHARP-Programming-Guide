using System;

class BaseClass
{
    public /*virtual*/ void Print()
    {
        Console.WriteLine("This is the base class.");
    }
}

class DerivedClass : BaseClass //Inheritance 
{
    new public /*override*/ void Print()
    {
        Console.WriteLine("This is the derived class.");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass derived = new DerivedClass();
        BaseClass mybc = (BaseClass)derived;

        derived.Print();
        mybc.Print();
    }
}

//  This is the derived class.
//  This is the base class.
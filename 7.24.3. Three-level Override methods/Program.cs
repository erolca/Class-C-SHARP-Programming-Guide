using System;

class BaseClass
{
    virtual public void Print()
    {
        Console.WriteLine("This is the base class.");
    }
}

class DerivedClass : BaseClass
{
    override public void Print()
    {
        Console.WriteLine("This is the derived class.");
    }
}

class SecondDerived : DerivedClass
{
    override public void Print()
    {
        Console.WriteLine("This is the second derived class.");
    }
}

class MainClass
{
    static void Main()
    {
        SecondDerived derived = new SecondDerived();
        // we have cast SecondDerived to the type BaseClass.
        //This is perfectly legal code (as we saw in the Polymorphism example).
        BaseClass mybc = (BaseClass)derived; //upcast

        derived.Print();
        mybc.Print();
    }
}

//This is the second derived class.
//This is the second derived class.
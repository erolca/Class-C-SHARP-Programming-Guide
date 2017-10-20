using System;

class BaseClass
{
    virtual public void Print()
    { Console.WriteLine("This is the base class."); }
}

class DerivedClass : BaseClass
{
    override public void Print()
    { Console.WriteLine("This is the derived class."); }
}

class SecondDerived : DerivedClass
{
    new public void Print()
    {
        Console.WriteLine("This is the second derived class.");
    }
}

class MainClass
{
    static void Main()
    {
        SecondDerived derived = new SecondDerived();
        BaseClass mybc = (BaseClass)derived;
        derived.Print();
        mybc.Print();
    }
}
//B.DoSomething
//A.DoSomething
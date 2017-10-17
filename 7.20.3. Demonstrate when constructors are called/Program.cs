using System;

//The general form of calling base constructor:
/*
derived-constructor(parameter-list) : base(arg-list) {
    // body of constructor
}
*/

// Create a base class. 
class BaseClass
{
    public BaseClass()
    {
        Console.WriteLine("Constructing BaseClass.");
    }
}

// Create a class derived from BaseClass. 
class DerivedClass : BaseClass
{
    public DerivedClass()
    {
        Console.WriteLine("Constructing DerivedClass.");
    }
}

// Create a class derived from DerivedClass. 
class DerivedDerivedClass : DerivedClass
{
    public DerivedDerivedClass()
    {
        Console.WriteLine("Constructing DerivedDerivedClass.");
    }
}

class MainClass
{
    public static void Main()
    {
        DerivedDerivedClass c = new DerivedDerivedClass();
    }
}

//Constructing BaseClass.
//Constructing DerivedClass.
//Constructing DerivedDerivedClass.
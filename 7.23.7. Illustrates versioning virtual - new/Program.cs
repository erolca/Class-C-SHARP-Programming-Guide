using System;

public class BaseClass
{
    public string firstName;
    public string lastName;

    public BaseClass(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public virtual void Accelerate()
    {
        Console.WriteLine("In BaseClass Accelerate() method");
        Console.WriteLine(lastName + " accelerating");
    }

}

public class DerivedClass : BaseClass
{

    public DerivedClass(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public new void Accelerate()
    {
        Console.WriteLine("In DerivedClass Accelerate() method");
        Console.WriteLine(lastName + " accelerating");
    }

}

class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Creating a DerivedClass object");
        DerivedClass myDerivedClass = new DerivedClass("Toyota", "MR2");

        Console.WriteLine("Calling myDerivedClass.Accelerate()");
        myDerivedClass.Accelerate();
    }
}

//Creating a DerivedClass object
//Calling myDerivedClass.Accelerate()
//In DerivedClass Accelerate() method
//MR2 accelerating
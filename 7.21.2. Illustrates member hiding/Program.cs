using System;

public class BaseClass
{
    public string lastName;
    public string firstName;

    public BaseClass(string lastName_, string firstName_)
    {
        Console.WriteLine("In BaseClass constructor");
        this.lastName = lastName_;
        this.firstName = firstName_;
        Console.WriteLine("this.lastName = " + this.lastName);
        Console.WriteLine("this.firstName = " + this.firstName);
    }

    public void DisplayfirstName()
    {
        Console.WriteLine("In BaseClass DisplayfirstName() method");
        Console.WriteLine("firstName = " + firstName);
    }

}

public class DerivedClass : BaseClass
{
    public new string firstName="C";

    public DerivedClass(string lastName_, string firstName_) : base(lastName_, "Test")
    {
        Console.WriteLine("In DerivedClass constructor");
        this.firstName = firstName_;
        Console.WriteLine("this.firstName = " + this.firstName);
    }

    public new void DisplayfirstName()
    {
        Console.WriteLine("In DerivedClass DisplayfirstName() method");
        Console.WriteLine("firstName = " + firstName);
        base.DisplayfirstName();
        
    }
}


class MainClass
{

    public static void Main()
    {
        Console.WriteLine("Creating a DerivedClass object");
        DerivedClass myDerivedClass = new DerivedClass("A", "B");

        Console.WriteLine("Back in Main() method");
        Console.WriteLine("myDerivedClass.lastName = " + myDerivedClass.lastName);
        Console.WriteLine("myDerivedClass.firstName = " + myDerivedClass.firstName);
        

        Console.WriteLine("Calling myDerivedClass.DisplayfirstName()");
        myDerivedClass.DisplayfirstName();

    }

}

//Creating a DerivedClass object
//In BaseClass constructor
//this.lastName = A
//this.firstName = Test
//In DerivedClass constructor
//this.firstName = B
//Back in Main() method
//myDerivedClass.lastName = A
//myDerivedClass.firstName = B
//Calling myDerivedClass.DisplayfirstName()
//In DerivedClass DisplayfirstName() method
//firstName = B
//In BaseClass DisplayfirstName() method
//firstName = Test
using System;

public class BaseClass
{
    public string lastName;
    public string firstName;

    public BaseClass(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public virtual void Accelerate()
    {
        Console.WriteLine("In BaseClass Accelerate() method");
        Console.WriteLine(firstName + " accelerating");
    }

}

public class DerivedClass : BaseClass
{
    public DerivedClass(string lastName, string firstName) : base(lastName, firstName)
    {
    }

    sealed public override void Accelerate()
    {
        Console.WriteLine("In DerivedClass Accelerate() method");
        Console.WriteLine(firstName + " accelerating");
    }

}



public class MyClass : DerivedClass
{
    public MyClass(string lastName, string firstName) : base(lastName, firstName)
    {
    }
    // Attempting to override Accelerate causes compiler error CS0239.
    //public override void Accelerate()
    //{
    //    base.Accelerate();
    //}

}



class MainClass
{

    public static void Main()
    {
        DerivedClass myDerivedClass = new DerivedClass("A", "M");

        Console.WriteLine("Calling myDerivedClass.Accelerate()");
        myDerivedClass.Accelerate();


        MyClass myclass = new MyClass("A", "M");
        myclass.Accelerate();
    }
}

//Calling myDerivedClass.Accelerate()
//In DerivedClass Accelerate() method
//M accelerating


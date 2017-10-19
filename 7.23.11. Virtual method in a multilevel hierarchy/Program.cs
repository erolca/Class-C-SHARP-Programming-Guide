using System;

//In a multilevel hierarchy, the system executes the first override-virtual method found in the hierarchy.
class BaseClass
{
    // Create virtual method in the base class.   
    public virtual void who()
    {
        Console.WriteLine("who() in BaseClass");
    }
}

class Derived1 : BaseClass
{
    // Override who() in a derived class.  
    public override void who()
    {
        Console.WriteLine("who() in Derived1");
    }
}

class Derived2 : Derived1
{
    // This class also does not override who(). 
  
}

class Derived3 : Derived2
{
    // This class does not override who().  
}

class MainClass
{
    public static void Main()
    {
        Derived3 dOb = new Derived3();
        BaseClass baseRef; // a base-class reference  

        baseRef = dOb;
        baseRef.who(); // calls Derived1's who()  
    }
}

//who() in Derived1
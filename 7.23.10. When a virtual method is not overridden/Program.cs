using System;
//7.23.10.	When a virtual method is not overridden, the base class method is used
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

class Derived2 : BaseClass
{
    // This class does not override who(). 
}

class MainClass
{
    public static void Main()
    {
        BaseClass baseOb = new BaseClass();
        Derived1 dOb1 = new Derived1();
        Derived2 dOb2 = new Derived2();

        BaseClass baseRef; // a base-class reference 

        baseRef = baseOb;
        baseRef.who();

        baseRef = dOb1;
        baseRef.who();

        baseRef = dOb2;
        baseRef.who(); // calls BaseClass's who() 
    }
}

//who() in BaseClass
//who() in Derived1
//who() in BaseClass
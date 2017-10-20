using System;
//7.25.3.	a subclass uses the keyword base to invoke a particular subclass constructor

//http://www.java2s.com/Tutorial/CSharp/0140__Class/asubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor.htm



public class Class1
{
    public static void Main(string[] args)
    {
        SubClass sc1 = new SubClass();

        SubClass sc2 = new SubClass(1, 2);

    }
}

public class BaseClass
{
    public BaseClass()
    {
        Console.WriteLine("Constructing BaseClass (default)");
    }
    public BaseClass(int i)
    {
        Console.WriteLine("Constructing BaseClass({0})", i);
    }
}

public class SubClass : BaseClass
{
    public SubClass()
    {
        Console.WriteLine("Constructing SubClass (default)");
    }
    public SubClass(int i1, int i2)
        : base(i1)
    {
        Console.WriteLine("Constructing SubClass({0}, {1})",i1, i2);
    }
}
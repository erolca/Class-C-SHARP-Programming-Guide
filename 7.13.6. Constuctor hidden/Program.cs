using System;

public class Class1
{
    public static void Main(string[] args)
    {
        SubClass sc1 = new SubClass();
        SubClass sc2 = new SubClass(0);
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
        Console.WriteLine("Constructing BaseClass (int)");
    }
}

public class SubClass : BaseClass
{
    public SubClass() 
    {
        Console.WriteLine("Constructing SubClass (default)");
    }
    public SubClass(int i)//:base(i)
    {
        Console.WriteLine("Constructing SubClass (int)");
    }
}
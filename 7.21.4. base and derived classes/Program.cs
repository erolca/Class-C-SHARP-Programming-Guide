using System;
class Base
{
    protected int i = 5;
    public void Print()
    {
        Console.WriteLine("i is {0}", i);
    }
}
class Derived : Base
{
    double d = 7.3;
    public void PrintBoth()
    {
        Console.WriteLine("i is {0}, d is {1}", i, d);
    }
}
class Test
{
    static void Main()
    {
        Base b = new Base();
        Console.WriteLine("b:");
        b.Print();

        Derived d = new Derived();
        Console.WriteLine("d:");
        d.Print();
        d.PrintBoth();
        Console.ReadLine();
    }
}
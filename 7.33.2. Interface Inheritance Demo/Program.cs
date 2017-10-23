using System;

interface ITest
{
    void Foo();
}

class Base : ITest
{
    public void Foo()
    {
        Console.WriteLine("Base.Foo (ITest implementation)");
    }
}

class MyDerived : Base
{
    public new void Foo()
    {
        Console.WriteLine("MyDerived.Foo");
       
    }
}




public class InterfaceInh3App
{
    public static void Main()
    {
        MyDerived myDerived = new MyDerived();
        Console.WriteLine();

        myDerived.Foo();
        Console.WriteLine();

        ((ITest)myDerived).Foo();
    }
}
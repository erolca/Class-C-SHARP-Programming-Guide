using System;

public class A
{
    public virtual void SomeMethod()
    {
        Console.WriteLine("A::SomeMethod");
    }
}

public class B : A
{
    public void SomeMethod()//without 'override' keyword
    //public override void SomeMethod() 
    {
        Console.WriteLine("B::SomeMethod");
    }
}

public class MainClass
{
    static void Main()
    {
        B b = new B();
        A a = b;

        a.SomeMethod();
    }
}
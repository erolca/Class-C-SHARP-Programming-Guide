using System;

class BaseClass
{
    public string Field1 = "base class field";
    public void Method1(string value)
    {
        Console.WriteLine("Base class    -- Method1: {0}", value);
    }
}

class DerivedClass : BaseClass
{
    public string Field2 = "derived class field";

    public void Method2(string value)
    {
        Console.WriteLine("Derived class -- Method2: {0}", value);
    }
}

class MainClass
{
    static void Main()
    {
        DerivedClass oc = new DerivedClass();
        oc.Method1(oc.Field1);               // Base method with base field
        oc.Method1(oc.Field2);               // Base method with derived field
        oc.Method2(oc.Field1);               // Derived method with base field
        oc.Method2(oc.Field2);               // Derived method with derived field
    }
}
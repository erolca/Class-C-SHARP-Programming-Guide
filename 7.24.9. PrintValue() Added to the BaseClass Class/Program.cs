using System;

public class BaseClass
{
    protected int Value;

    public BaseClass()
    {
        Value = 123;
    }

    public virtual void PrintValue()
    {
        Console.WriteLine("Value: " + Value);
    }
}

public class DerivedClass : BaseClass
{
    public void PrintValue()
    {
        Console.WriteLine("Value = " + Value);
    }
}

class MainClass
{
    public static void Main()
    {
        DerivedClass DerivedClassObject = new DerivedClass();

        DerivedClassObject.PrintValue();
    }
}
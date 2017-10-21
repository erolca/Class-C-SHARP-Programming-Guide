using System;


public partial class MyClass
{

    public void CoreMethodA()
    {
        Console.WriteLine("MyClass.CoreA");
    }
}

public class Starter
{
    public static void Main()
    {
        MyClass obj = new MyClass();
        obj.CoreMethodA();
        obj.ExtendedMethodA();
    }
}


public partial class MyClass
{

    public void ExtendedMethodA()
    {
        Console.WriteLine("MyClass.ExtendedA");
    }
}
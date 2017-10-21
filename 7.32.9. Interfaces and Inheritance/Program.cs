using System;

interface MyInterface
{
    void MyMethodInInterface();
}

public class Base : MyInterface
{
    public void MyMethodInInterface()
    {
        Console.WriteLine("Base.MyMethodInInterface()");
    }
}

public class Derived : Base
{
    public new void MyMethodInInterface()
    {
        Console.WriteLine("Derived.MyMethodInInterface()");
    }
}
class MainClass
{
    public static void Main()
    {
        Derived der = new Derived();
        der.MyMethodInInterface();
        MyInterface helper = (MyInterface)der;
        helper.MyMethodInInterface();
    }
}

//Derived.MyMethodInInterface()
//Base.MyMethodInInterface()
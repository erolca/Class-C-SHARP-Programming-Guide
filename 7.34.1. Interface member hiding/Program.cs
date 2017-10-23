using System;


public interface InterfaceA
{
    void MethodA();
}


public interface InterfaceB : InterfaceA
{
    new void MethodA();  // hides MethodA() in InterfaceA
}

public class MyClass : InterfaceB
{

    void InterfaceB.MethodA()
    {
        Console.WriteLine("InterfaceB implementation of MethodA()");
    }

    public void MethodA()
    {
        Console.WriteLine("InterfaceA implementation of MethodA()");
    }

}


class MainClass
{
    public static void Main()
    {
        MyClass myClass = new MyClass();

        Console.WriteLine("Calling myClass.MethodA()");
        myClass.MethodA(); 

        InterfaceB mySteerable = myClass as InterfaceB;
        Console.WriteLine("Calling mySteerable.MethodA()");
        mySteerable.MethodA();
        ((InterfaceB)myClass).MethodA();

        InterfaceA myDrivable = myClass as InterfaceA;
        Console.WriteLine("Calling myDrivable.MethodA()");
        myDrivable.MethodA();
        ((InterfaceA)myClass).MethodA();

    }

}
using System;

interface MyInterfaceA
{
    int Method(int x);
}

interface MyInterfaceB
{
    int Method(int x);
}

// MyClass implements both interfaces. 
class MyClass : MyInterfaceA, MyInterfaceB
{

    // explicitly implement the two Method()s 
    int MyInterfaceA.Method(int x)
    {
        return x + x;
    }
    int MyInterfaceB.Method(int x)
    {
        return x * x;
    }

    // call Method() through an interface reference. 
    public int MethodA(int x)
    {
        MyInterfaceA a_ob;
        a_ob = this;
        return a_ob.Method(x); // calls MyInterfaceA 
    }

    public int MethodB(int x)
    {
        MyInterfaceB b_ob;
        b_ob = this;
        return b_ob.Method(x); // calls MyInterfaceB 
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass ob = new MyClass();

        Console.Write("Calling MyInterfaceA.Method(): ");
        Console.WriteLine(ob.MethodA(3));

        Console.Write("Calling MyInterfaceB.Method(): ");
        Console.WriteLine(ob.MethodB(3));
    }
}

//Calling MyInterfaceA.Method(): 6
//Calling MyInterfaceB.Method(): 9
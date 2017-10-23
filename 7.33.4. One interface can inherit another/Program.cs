using System;

public interface BaseInterface
{
    void meth1();
    void meth2();
}

// BaseInterface now includes meth1() and meth2() -- it adds meth3(). 
public interface BaseInterface2 : BaseInterface
{
    void meth3();
}

// This class must implement all of BaseInterface and BaseInterface 
class MyClass : BaseInterface2
{
    public void meth1()
    {
        Console.WriteLine("Implement meth1().");
    }

    public void meth2()
    {
        Console.WriteLine("Implement meth2().");
    }

    public void meth3()
    {
        Console.WriteLine("Implement meth3().");
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass ob = new MyClass();

        ob.meth1();
        ob.meth2();
        ob.meth3();
    }
}

//Implement meth1().
//Implement meth2().
//Implement meth3().
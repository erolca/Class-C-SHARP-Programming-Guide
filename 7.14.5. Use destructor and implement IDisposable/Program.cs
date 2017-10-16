using System;
public class MyClass : IDisposable
{
    ~MyClass()
    {
        Console.WriteLine("In destructor");
    }

    public void Dispose()
    {
        Console.WriteLine("In Dispose()");
        GC.SuppressFinalize(this);
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        MyClass c1, c2, c3, c4;

        c1 = new MyClass();
        c2 = new MyClass();
        c3 = new MyClass();
        c4 = new MyClass();

        Console.WriteLine("\n***** Disposing c1 and c3 *****");
        c1.Dispose();
        c3.Dispose();
    }
}

//***** Disposing c1 and c3*****
//In Dispose()
//In Dispose()
//In destructor
//In destructor
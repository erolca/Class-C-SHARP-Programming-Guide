using System;
public class MyClass : IDisposable
{
    public MyClass() { }

    public void Dispose()
    {
        Console.WriteLine("In Dispose()");
    }
}

public class MainClass
{
    public static int Main(string[] args)
    {

        using (MyClass c = new MyClass())
        {

        }



        MyClass c1 = new MyClass();
        c1.Dispose();
        return 0;

    }
}

//In Dispose()
//In Dispose()
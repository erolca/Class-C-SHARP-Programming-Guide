using System;

class MainClass
{
    static void Main(string[] args)
    {
        B MyB = new D();
        D MyD = new D();

        MyB.Display();
        MyD.Display();
    }
}

public class B //base
{
    public virtual void Display()
    {
        Console.WriteLine("Class B's Display Method");
    }
}
public class C : B
{
    public override void Display()
    {
        Console.WriteLine("Class C's Display Method");
    }
}
public class D : C
{
    public override void Display()
    {
        Console.WriteLine("Class D's Display Method");
    }
}

//Class D's Display Method
//Class D's Display Method
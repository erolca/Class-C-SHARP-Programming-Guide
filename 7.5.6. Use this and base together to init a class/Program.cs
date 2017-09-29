using System;

class Base
{
    public Base(int x)
    {
        Console.WriteLine("Base.Base(int)");
        this.x = x;
    }

    public int x = 0;
}

class Derived : Base
{

    public int a = 0;
    public int b = 0;


    public Derived(int a) : base(a)
    {
        Console.WriteLine("Derived.Derived(int)");
        this.a = a;
    }


    public Derived(int a, int b) : this(a)
    {
        Console.WriteLine("Derived.Derived(int, int)");
        this.a = a;
        this.b = b;
    }

  
}

public class MainClass
{
    static void Main()
    {
        Derived b = new Derived(1, 2);
    }
}
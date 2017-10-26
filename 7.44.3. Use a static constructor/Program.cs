using System;

class Cons
{
    public static int a;
    public int b;

    // static constructor 
    static Cons()
    {
        a = 99;
        Console.WriteLine("Inside static constructor.");
    }

    // instance constructor 
    public Cons()
    {
        b = 100;
        Console.WriteLine("Inside instance constructor.");
    }
}

class MainClass
{
    public static void Main()
    {
        Cons ob = new Cons();

        Console.WriteLine("Cons.a: " + Cons.a);
        Console.WriteLine("ob.b: " + ob.b);
    }
}

//Inside static constructor.
//Inside instance constructor.
//Cons.a: 99
//ob.b: 100
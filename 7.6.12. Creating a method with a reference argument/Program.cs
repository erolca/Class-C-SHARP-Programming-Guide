using System;
class MainClass
{
    static void Main()
    {
        int x = 10;

        Console.WriteLine("Before calling non-ref function, x = {0}", x);
        NonRefFunction(x);
        Console.WriteLine("After calling non-ref function, x = {0}", x);
        RefFunction(ref x);
        Console.WriteLine("After calling ref function, x = {0}", x);
    }

    static void NonRefFunction(int x)
    {
        Console.WriteLine("Top of NonRefFunction. X = {0}", x);
        x = x + 10;
        Console.WriteLine("Bottom of NonRefFunction. X = {0}", x);
    }

    static void RefFunction(ref int x)
    {
        Console.WriteLine("Top of RefFunction. X = {0}", x);
        x = x + 10;
        Console.WriteLine("Bottom of RefFunction. X = {0}", x);
    }
}
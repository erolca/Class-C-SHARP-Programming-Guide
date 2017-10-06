using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine(Fibonacci(10));
    }
    static int Fibonacci(int x)
    {
        if (x <= 1)
            return 1;
        return Fibonacci(x - 1) + Fibonacci(x - 2);
    }
}
//89
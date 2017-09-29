using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}

public class MainClass
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        int sum = calc.Add(3, 5);
        Console.WriteLine("3 + 5 = {0}", sum);
    }

}
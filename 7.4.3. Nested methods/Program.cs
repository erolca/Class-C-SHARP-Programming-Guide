using System;

class MainClass
{
    static void MethodA(int par1, int par2)
    {
        Console.WriteLine("Enter MethodA: {0}, {1}", par1, par2);
        MethodB(11, 18);
        Console.WriteLine("Exit MethodA");
    }

    static void MethodB(int par1, int par2)
    {
        Console.WriteLine("Enter MethodB: {0}, {1}", par1, par2);
        Console.WriteLine("Exit MethodB");
    }

    static void Main()
    {
        MethodA(15, 30);
    }
}
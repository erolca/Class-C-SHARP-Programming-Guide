using System;

class ChkNum
{
    public int sum(int a, int b)
    {
        int max;
        max = a < b ? a : b;

        return max;
    }
}

class MainClass
{
    public static void Main()
    {
        ChkNum ob = new ChkNum();
        int a, b;

        a = 7;
        b = 8;
        Console.WriteLine(ob.sum(a, b));

        a = 100;
        b = 8;
        Console.WriteLine(ob.sum(a, b));

        a = 100;
        b = 75;
        Console.WriteLine(ob.sum(a, b));

    }
}
using System;

public class Thing
{
    public int i = 2;
    public int j = 3;
}

public class objectTypeApp
{
    public static void Main()
    {
        object a;
        a = 1;
        Console.WriteLine(a);
        Console.WriteLine(a.ToString());
        Console.WriteLine(a.GetType());
        Console.WriteLine();

        Thing b = new Thing();
        Console.WriteLine(b);
        Console.WriteLine(b.ToString());
        Console.WriteLine(b.GetType());
    }
}
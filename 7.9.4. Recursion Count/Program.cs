using System;

class MainClass
{
    public static void Count(int InVal)
    {
        if (InVal == 0)
            return;
        Count(InVal - 1);

        Console.WriteLine("{0} ", InVal);
    }

    public static void Main()
    {
        Count(3);
    }
}
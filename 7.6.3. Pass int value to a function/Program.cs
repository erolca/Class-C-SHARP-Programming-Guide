using System;

class MainClass
{
    public static void Main()
    {
        int SomeInt = 6;

        int s = Sum(5, SomeInt);

        Console.WriteLine(s);
    }

    //Call-by-value:
    public static int Sum(int x, int y)               // Declare the method.
    {
        return x + y;                                  // Return the sum.
    }

}
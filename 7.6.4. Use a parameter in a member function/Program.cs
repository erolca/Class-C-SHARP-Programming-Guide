using System;

class ChkNum
{
    // Return true if x is prime. 
    public bool isPrime(int x)
    {
        for (int i = 2; i <= x / i; i++)
            if ((x % i) == 0) return false;

        return true;
    }
}

class MainClass
{
    public static void Main()
    {
        ChkNum ob = new ChkNum();

        for (int i = 1; i < 10; i++)
            if (ob.isPrime(i)) Console.WriteLine(i + " is prime.");
            else Console.WriteLine(i + " is not prime.");

    }
}
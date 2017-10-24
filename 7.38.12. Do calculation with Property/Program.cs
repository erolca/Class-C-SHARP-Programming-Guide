using System;

public class SomeClass
{
    private int num;
    public SomeClass(int i)
    {
        num = i;
    }
    public int Num
    {
        get { return num; }
        set { num = value; }
    }
}

public class CompoundAssPropApp
{
    public static void Main(string[] args)
    {
        SomeClass sc = new SomeClass(42);
        Console.WriteLine("{0}", sc.Num);

        sc.Num = sc.Num + 5;
        Console.WriteLine("{0}", sc.Num);
    }
}
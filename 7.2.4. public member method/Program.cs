using System;

class MyClass
{
    public int High, Low;

    public int Sum()
    {
        return High + Low;
    }
}

class MainClass
{
    static void Main()
    {
        MyClass T1 = new MyClass();
        MyClass T2 = new MyClass();

        T1.High = 76;
        T1.Low = 57;

        T2.High = 75;
        T2.Low = 53;

        Console.WriteLine("T1: {0}, {1}, {2}", T1.High, T1.Low, T1.Sum());
        Console.WriteLine("T2: {0}, {1}, {2}", T2.High, T2.Low, T2.Sum());
    }
}
//T1: 76, 57, 133
//T2: 75, 53, 128
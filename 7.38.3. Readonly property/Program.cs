using System;

class MyClass
{
    public double A = 3;
    public double B = 4;

    public double MyValue
    {
        get { return A * B; }
    }
}

class MainClass
{
    static void Main()
    {
        MyClass c = new MyClass();
        Console.WriteLine("MyValue: {0}", c.MyValue);
    }
}

//MyValue: 12
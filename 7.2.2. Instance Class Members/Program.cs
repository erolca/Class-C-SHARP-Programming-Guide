using System;

class MyClass
{
    public int memberVariable;
}

class MainClass
{
    static void Main()
    {
        MyClass d1 = new MyClass();
        MyClass d2 = new MyClass();
        d1.memberVariable = 10;
        d2.memberVariable = 28;
        Console.WriteLine("d1 = {0}, d2 = {1}", d1.memberVariable, d2.memberVariable);
    }
}

//d1 = 10, d2 = 28
using System;

class MyClass
{
    public int Val = 20;
}

class MainClass
{
    static void MyMethod(out MyClass f1, out int f2)
    {
        f1 = new MyClass();
        f1.Val = 25;
        f2 = 15;
    }

    static void Main()
    {
        MyClass myObject = null;
        int intValue;

        MyMethod(out myObject, out intValue);

        Console.WriteLine("After  -- myObject.Val: {0}, intValue: {1}", myObject.Val, intValue);
    }
}
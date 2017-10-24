using System;


class MyClass
{
    private int privateInnerValue = 10;
    public int MyValue
    {
        set
        {
            privateInnerValue = value;
        }
        get
        {
            return privateInnerValue;
        }
    }
}
class MainClass
{
    static void Main()
    {
        MyClass c = new MyClass();
        Console.WriteLine("MyValue: {0}", c.MyValue);
        c.MyValue = 20;
        Console.WriteLine("MyValue: {0}", c.MyValue);
    }
}
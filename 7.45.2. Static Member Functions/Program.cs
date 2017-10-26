using System;

class MyClass
{
    public MyClass()
    {
        instanceCount++;
    }
    public static int GetInstanceCount()
    {
        return (instanceCount);
    }
    static int instanceCount = 0;
}

class MainClass
{
    public static void Main()
    {
        MyClass my = new MyClass();
        Console.WriteLine(MyClass.GetInstanceCount());
    }
}
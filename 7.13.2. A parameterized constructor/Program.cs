using System;

class MyClass
{
    public int x;

    public MyClass(int i)
    {
        x = i;
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass t1 = new MyClass(10);
        MyClass t2 = new MyClass(88);

        Console.WriteLine(t1.x + " " + t2.x);
    }
}
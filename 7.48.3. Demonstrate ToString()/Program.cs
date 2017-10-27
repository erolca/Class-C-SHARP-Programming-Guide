using System;

class MyClass
{
    static int count = 0;
    int id;

    public MyClass()
    {
        id = count;
        count++;
    }

    public override string ToString()
    {
        return "MyClass object #" + id;
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass ob1 = new MyClass();
        MyClass ob2 = new MyClass();
        MyClass ob3 = new MyClass();

        Console.WriteLine(ob1);
        Console.WriteLine(ob2);
        Console.WriteLine(ob3);

    }
}
//MyClass object #0
//MyClass object #1
//MyClass object #2
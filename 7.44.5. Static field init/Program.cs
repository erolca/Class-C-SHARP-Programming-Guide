using System;

public class MyClass
{
    private static int InitX()
    {
        Console.WriteLine("MyClass.InitX()");
        return 1;
    }
    private static int InitY()
    {
        Console.WriteLine("MyClass.InitY()");
        return 2;
    }
    private static int InitA()
    {
        Console.WriteLine("MyClass.InitA()");
        return 3;
    }
    private static int InitB()
    {
        Console.WriteLine("MyClass.InitB()");
        return 4;
    }
  
    private int y = InitY();
    private int x = InitX();

    private static int a = InitA();
    private static int b = InitB();

    public static int A { get => a; set => a = value; }
    public static int B { get => b; set => b = value; }
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
}

public class MainClass
{
    static void Main()
    {
        MyClass a = new MyClass();

        Console.WriteLine("Public Fields: {0}, {1}", a.X, a.Y);

        Console.WriteLine("Static fields: {0}, {1}", MyClass.A, MyClass.B);
    }
}


//MyClass.InitA()
//MyClass.InitB()
//MyClass.InitY()
//MyClass.InitX()

//short cuts https://msdn.microsoft.com/en-us/library/ms366756(v=vs.90).aspx

/*
 Refactor.EncapsulateField
CTRL + R, E

    Refactor.ExtractInterface
CTRL + R, I

    Refactor.ExtractMethod
CTRL + R, M


    Refactor.PromoteLocalVariabletoParameter
CTRL + R, P

    Refactor.Rename
F2
- or -
CTRL + R, R

    Refactor.ReorderParameters
CTRL + R, O




 */

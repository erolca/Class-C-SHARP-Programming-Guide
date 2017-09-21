using System;

class MyClass
{
    int nonStaticVariable;
    static int staticVariable;

    public void SetVars(int v1, int v2)
    {
        nonStaticVariable = v1;
        staticVariable = v2;
    }

    public void Display()
    {
        Console.WriteLine("nonStaticVariable= {0}, staticVariable= {1}", nonStaticVariable, staticVariable);
    }
}

class MainClass
{
    static void Main()
    {
        MyClass d1 = new MyClass(), d2 = new MyClass();

        d1.SetVars(2, 4);
        d1.Display();
        d2.Display();

        d2.SetVars(15, 17);
        d2.Display();
        d1.Display();

    }
}
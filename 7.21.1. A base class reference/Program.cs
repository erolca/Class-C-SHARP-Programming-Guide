using System;

class BaseClass
{
    public int a;

    public BaseClass(int i)
    {
        a = i;
    }
}

class DerivedClass : BaseClass
{
    public int b;

    public DerivedClass(int i, int j) : base(j)
    {
        b = i;
    }
}

class MainClass
{
    public static void Main()
    {
        BaseClass x = new BaseClass(10);
        BaseClass x2;
        DerivedClass y = new DerivedClass(5, 6);

        x2 = x; // OK, both of same type 
        Console.WriteLine("x2.a: " + x2.a);

        x2 = y; // Ok because DerivedClass is derived from BaseClass 
        Console.WriteLine("x2.a: " + x2.a);

        // BaseClass references know only about BaseClass members 
        x2.a = 19; // OK 
                   //    x2.b = 27; // Error, BaseClass doesn't have a b member 
    }
}
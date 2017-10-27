using System;
class BaseClass
{
    int i = 5;
    public virtual void Print()
    {
        Console.WriteLine("i is {0}", i);
    }
    public override String ToString()
    {
        return i.ToString();
    }
}
class DerivedClass : BaseClass
{
    double d = 2.1;
    public override void Print()
    {
        base.Print();
        Console.WriteLine("d is {0}", d);
    }
    public override String ToString()
    {
        return base.ToString() + " " + d.ToString();
    }
}


class MainClass
{
    public static void Main()
    {
        BaseClass b = new BaseClass();
        DerivedClass d = new DerivedClass();
        BaseClass bd = new DerivedClass();
        b.Print();
        d.Print();
        bd.Print();
        Console.WriteLine("b: {0}, d: {1}, bd: {2}", b, d, bd);
        Console.WriteLine("\n b: {0}",b);
        Console.WriteLine("\n d: {0}",d);
        Console.WriteLine("\n bd: {0}",bd);
    }
}
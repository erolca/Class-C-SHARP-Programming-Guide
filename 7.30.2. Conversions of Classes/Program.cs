using System;

public class Base
{
    public virtual void talk()
    {
        Console.WriteLine("Base");
    }
}
public class Derived : Base
{
    public override void talk()
    {
        Console.WriteLine("Derived");
    }
}
public class Test
{
    public static void Main()
    {
        Derived d = new Derived();
        Base b = d;

        b.talk();
        Derived d2 = (Derived)b;

        object o = d;
        Derived d3 = (Derived)o;//cast  keyword->(Derived)
        d3.talk();
    }
}
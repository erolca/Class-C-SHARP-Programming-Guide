using System;

public class Class1 : Class2
{
    public static void Main(string[] strings)
    {
        Class1 class1 = new Class1();
        Class2 class2 = new Class2();
        Class3 class3 = new Class3();

        class2.A_public();

        class1.B_protected();
        class1.C_private();

        class3.D_internal();

        class1.E_internalprotected();
        class3.E_internalprotected();

   
    }

    public void C_private()
    {
        Console.WriteLine("Class1.C_private");
    }
}

internal class Class3
{
    public void A_public()
    {
        Console.WriteLine("Class3.A_public");
    }

    protected void B_protected()
    {
        Console.WriteLine("Class3.B_protected");
    }

    internal void D_internal()
    {
        Console.WriteLine("Class3.D_internal");
    }

    public void E_internalprotected()
    {
        Console.WriteLine("Class3.E_internalprotected");
    }
}


public class Class2
{
    public void A_public()
    {
        Console.WriteLine("Class2.A_public");
    }
    protected void B_protected()
    {
        Console.WriteLine("Class2.B_protected");
    }
    private void C_private()
    {
        Console.WriteLine("Class2.C_private");
    }
    internal void D_internal()
    {
        Console.WriteLine("Class2.D_internal");
    }
    internal protected void E_internalprotected()
    {
        Console.WriteLine("Class2.E_internalprotected");
    }
}
using System;

public class A
{
    private int myValue;

    public int MyValue
    {
        get
        {
            System.Console.WriteLine("Getting myValue");
            return myValue;
        }

        set
        {
            System.Console.WriteLine("Setting myValue");
            myValue = value;
        }
    }
}

public class MainClass
{
    static void Main()
    {
        A obj = new A();

        obj.MyValue = 1;
        System.Console.WriteLine("obj.Value = {0}",
                                  obj.MyValue);
    }
}

//Setting myValue
//Getting myValue
//obj.Value = 1
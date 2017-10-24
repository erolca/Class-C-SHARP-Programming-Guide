using System;

public sealed class Value
{
    public int intValue = 10;
}

public sealed class MyController
{
    public MyController(Value pimpl_)
    {
        this.pimpl = pimpl_;
    }

    public int IntValue
    {
        get
        {
            return pimpl.intValue;
        }
    }

    private readonly Value pimpl;
}




public sealed class MainClass
{
    static void Main()
    {
        Value someNumber = new Value();
        someNumber.intValue = 25;

        MyController d = new MyController(someNumber);
        Console.WriteLine("{0}", d.IntValue);
    }
}

//The person's full name is B A
//The person's full name is A c
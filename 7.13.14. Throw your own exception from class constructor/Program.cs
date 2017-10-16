using System;

public class HelloWorld
{
    public static void Main()
    {
        try
        {
            Discount big_discount = new Discount(56);
        }
        catch (MyException ex)
        {
            Console.WriteLine("Exception Caught");
            Console.WriteLine(ex.Message);
        }
    }
}
public class Discount
{
    private int percent;
    public Discount(int percent)
    {
        this.percent = percent;
        if (percent > 50)
            throw new MyException("Discount > 50%");
    }
}

public class MyException : Exception
{
    public MyException(String msg) : base(msg)
    {
    }
}
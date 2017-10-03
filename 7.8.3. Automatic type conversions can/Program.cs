using System;


//  7.8.3    Automatic type conversions can affect overloaded method resolution: int, double
//  7.8.4.	Automatic type conversions can affect overloaded method resolution: byte

using System;

class Overload2
{
    public void f(int x)
    {
        Console.WriteLine("Inside f(int): " + x);
    }

    public void f(double x)
    {
        Console.WriteLine("Inside f(double): " + x);
    }
}

class MainClass
{
    public static void Main()
    {
        Overload2 ob = new Overload2();

        int i = 10;
        double d = 10.1;

        byte b = 99;
        short s = 10;
        float f = 11.5F;


        ob.f(i); // calls ob.f(int) 
        ob.f(d); // calls ob.f(double) 

        ob.f(b); // calls ob.f(int) -- type conversion 
        ob.f(s); // calls ob.f(int) -- type conversion 
        ob.f(f); // calls ob.f(double) -- type conversion 
    }
}

//Inside f(int): 10
//Inside f(double): 10.1
//Inside f(int): 99
//Inside f(int): 10
//Inside f(double): 11.5
using System;

class SimpProp
{
    int prop;

    public SimpProp()
    {
        prop = 0;
    }

    public int MyProp
    {
        get
        {
            return prop;
        }
        set
        {
            prop = value;
        }
    }
}

class MainClass
{
    public static void Main()
    {
        SimpProp ob = new SimpProp();

        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);

        ob.MyProp = 100;
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);

        Console.WriteLine("Attempting to assign -10 to ob.MyProp");
        ob.MyProp = -10;
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);
    }
}

//Original value of ob.MyProp: 0
//Value of ob.MyProp: 100
//Attempting to assign -10 to ob.MyProp
//Value of ob.MyProp: -10
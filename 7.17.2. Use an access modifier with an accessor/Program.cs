using System;

class MySequence
{
    int prop;

    public MySequence() { prop = 0; }


    //properties
    public int MyProp
    {
        get
        {
            return prop;
        }
        private set
        { // private  
            prop = value;
        }
    }


    //method
    public void increaseSequence()
    {
        MyProp++;
    }
}

class MainClass
{
    public static void Main()
    {
        MySequence ob = new MySequence();
        //ob.MyProp = 5;
        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);

        ob.increaseSequence();
        Console.WriteLine("Value of ob.MyProp after increment: "
                          + ob.MyProp);
    }
}

//Original value of ob.MyProp: 0
//Value of ob.MyProp after increment: 1
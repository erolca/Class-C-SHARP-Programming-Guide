using System;

class MyClass
{
    static int myValue;

    public static int StaticProperty
    {
        set { myValue = value; }
        get { return myValue; }
    }

}

class MainClass
{
    static void Main()
    {
        Console.WriteLine("Init Value: {0}", MyClass.StaticProperty);
        MyClass.StaticProperty = 10;
        Console.WriteLine("New Value : {0}", MyClass.StaticProperty);
    }
}

//Init Value: 0
//New Value : 10
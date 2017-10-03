using System;

class MainClass
{
    static void Main(string[] args)
    {
        int MyInt = 5;

        MyMethodRef(ref MyInt);

        Console.WriteLine(MyInt);
    }

    static public int MyMethodRef(ref int myInt)
    {
        myInt = myInt + myInt;
        return myInt;
    }
}
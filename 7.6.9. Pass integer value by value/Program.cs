using System;

class MainClass
{
    static void Main(string[] args)
    {
        int MyInt = 5;

        MyMethod(MyInt);

        Console.WriteLine(MyInt);
    }

    static public int MyMethod(int myInt)
    {
        myInt = myInt + myInt;
        return myInt;
    }
}
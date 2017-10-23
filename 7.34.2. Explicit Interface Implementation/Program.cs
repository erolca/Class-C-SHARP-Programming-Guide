using System;

interface InterfaceOne
{
    void Execute();
}

interface InterfaceTwo
{
    void Execute();
}

class MyImplementation : InterfaceOne, InterfaceTwo
{
    void InterfaceOne.Execute()
    {
        Console.WriteLine("InterfaceOne.Execute implementation");
    }
    void InterfaceTwo.Execute()
    {
        Console.WriteLine("InterfaceTwo.Execute implementation");
    }
}

class MainClass
{
    public static void Main()
    {
        MyImplementation MyImplementation = new MyImplementation();

        InterfaceOne InterfaceOne = (InterfaceOne)MyImplementation;
        InterfaceOne.Execute();

        InterfaceTwo InterfaceTwo = (InterfaceTwo)MyImplementation;
        InterfaceTwo.Execute();
    }
}

//InterfaceOne.Execute implementation
//InterfaceTwo.Execute implementation
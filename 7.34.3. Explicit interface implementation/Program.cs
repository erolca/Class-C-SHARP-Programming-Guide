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

    public void Execute()
    {
        ((InterfaceOne)this).Execute();
      
    }
}

class MainClass
{
    public static void Main()
    {
        MyImplementation MyImplementation = new MyImplementation();

        MyImplementation.Execute();
    }
}
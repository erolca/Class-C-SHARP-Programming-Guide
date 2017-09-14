using System;

class MainClass
{
    MainClass()
    {
        Console.WriteLine("MainClass Constructor Called");
    }

    ~MainClass()
    {
        Console.WriteLine("MainClass Destructor Called");
    }
    void PrintAMessage(string msg)
    {
        Console.WriteLine("PrintAMessage: {0}", msg);
    }
    void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    static void Main()
    {
        Console.WriteLine("Top of function main");
        MainClass app = new MainClass();
        app.PrintAMessage("Hello from class");
        Console.WriteLine("Bottom of function main");
        app.Dispose();
    }
}
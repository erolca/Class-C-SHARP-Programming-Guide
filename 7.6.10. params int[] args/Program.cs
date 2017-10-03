using System;

class MainClass
{
    static void Main(string[] args)
    {

        MyMethod(5, 5, 5, 5);

    }

    static public void MyMethod(params int[] args)
    {
        for (int I = 0; I < args.Length; I++)
            Console.WriteLine(args[I]);
    }
}
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        MainClass c1 = new MainClass();

        MainClass c2 = c1;
        object o = c2;

        if (o.Equals(c1) && c2.Equals(o))
            Console.WriteLine("Same instance!\n");

    }
}
//Same instance!
using System;

class Overload
{
    public void ovlDemo()
    {
        Console.WriteLine("No parameters");
    }

    // Overload ovlDemo for one integer parameter.  
    public void ovlDemo(int a)
    {
        Console.WriteLine("One parameter: " + a);
    }

    // Overload ovlDemo for two integer parameters.  
    public int ovlDemo(int a, int b)
    {
        Console.WriteLine("Two parameters: " + a + " " + b);
        return a + b;
    }

    // Overload ovlDemo for two double parameters.  
    public double ovlDemo(double a, double b)
    {
        Console.WriteLine("Two double parameters: " +
                           a + " " + b);
        return a + b;
    }
}

class MainClass
{
    public static void Main()
    {
        Overload ob = new Overload();
        int resI;
        double resD;

        // call all versions of ovlDemo()  
        ob.ovlDemo();
        Console.WriteLine();

        ob.ovlDemo(2);
        Console.WriteLine();

        resI = ob.ovlDemo(4, 6);
        Console.WriteLine("Result of ob.ovlDemo(4, 6): " +
                           resI);
        Console.WriteLine();


        resD = ob.ovlDemo(1.1, 2.32);
        Console.WriteLine("Result of ob.ovlDemo(1.1, 2.32): " +
                           resD);
    }
}

//No parameters

//One parameter: 2

//Two parameters: 4 6
//Result of ob.ovlDemo(4, 6): 10

//Two double parameters: 1.1 2.32
//Result of ob.ovlDemo(1.1, 2.32): 3.42
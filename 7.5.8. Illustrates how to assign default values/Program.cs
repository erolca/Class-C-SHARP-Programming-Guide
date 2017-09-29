using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//7.5.8.	Illustrates how to assign default values to fields using initializers

class PC
{
    public string make = "AAA";
    public string model = "T";
    public string color;
    public int yearBuilt = 1910;

    public void Start()
    {
        System.Console.WriteLine(yearBuilt + " yearBuilt");
    }

}

class MainClass
{

    public static void Main()
    {
        PC myPC = new PC();

        System.Console.WriteLine("myPC.make = " + myPC.make);
        System.Console.WriteLine("myPC.model = " + myPC.model);
        if (myPC.color == null)
        {
            System.Console.WriteLine("myPC.color is null");
        }
        System.Console.WriteLine("myPC.yearBuilt = " + myPC.yearBuilt);
    }
}
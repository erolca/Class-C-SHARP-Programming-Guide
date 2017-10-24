using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//	7.35.4.	Use expressions to calculate and display the circumference of a circle
class MainClass
{

    public static void Main()
    {

        const double Pi = 3.14159;
        double diameter = 2.5;

        double circumference = Pi * diameter;

        System.Console.WriteLine("Circumference = " + circumference);

    }

}

//Circumference = 7.853975
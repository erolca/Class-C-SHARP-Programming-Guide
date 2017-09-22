using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
///  The new operator dynamically allocates memory for an object and returns a reference to it.
/// This reference is, more or less, the address in memory of the object allocated by new.
/// This reference is then stored in a variable.
/// 7.3.1.	Declare class fields and methods
/// 7.3.2.	Declare a House object reference named myHouse
/// 7.3.3.	Creating a House object and assigning its memory location to myHouse
/// 7.3.4.	Assign values to the House object's fields using object renerence

/// </summary>



public class House
{
    public string make;
    public string model;
    public string color;
    public int yearBuilt;

    public void Start()
    {
        System.Console.WriteLine(model + " started");
    }

    public void Stop()
    {
        System.Console.WriteLine(model + " stopped");
    }

}

class MainClass
{

    public static void Main()
    {

        House myHouse;

        System.Console.WriteLine("Creating a House object and assigning its memory location to myHouse");
        myHouse = new House();


        //	7.3.4.	Assign values to the House object's fields using object renerence
        myHouse.make = "ABC";
        myHouse.model = "Apartment";
        myHouse.color = "black";
        myHouse.yearBuilt = 1995;

        //7.3.5.	Display the field values using object reference
        System.Console.WriteLine("myHouse details:");
        System.Console.WriteLine("myHouse.make = " + myHouse.make);
        System.Console.WriteLine("myHouse.model = " + myHouse.model);
        System.Console.WriteLine("myHouse.color = " + myHouse.color);
        System.Console.WriteLine("myHouse.yearBuilt = " + myHouse.yearBuilt);

    }

}

//Creating a House object and assigning its memory location to myHouse

/*  7.3.5.	Display the field values using object reference*/
//myHouse details:
//myHouse.make = ABC
//myHouse.model = Apartment
//myHouse.color = black
//myHouse.yearBuilt = 1995
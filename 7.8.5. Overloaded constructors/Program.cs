using System;

public class Car
{
    private string make;
    private string model;
    private string color;
    private int yearBuilt;


    //constructors-1
    public Car()
    {
        this.make = "Ford";
        this.model = "Mustang";
        this.color = "red";
        this.yearBuilt = 1970;
    }

    //constructors-2
    public Car(string make)
    {
        this.make = make;
        this.model = "Corvette";
        this.color = "silver";
        this.yearBuilt = 1969;
    }

    //constructors-3
    public Car(string make, string model, string color, int yearBuilt)
    {
        this.make = make;
        this.model = model;
        this.color = color;
        this.yearBuilt = yearBuilt;
    }

    public void Display()
    {
        System.Console.WriteLine("make = " + make);
        System.Console.WriteLine("model = " + model);
        System.Console.WriteLine("color = " + color);
        System.Console.WriteLine("yearBuilt = " + yearBuilt);
    }

}

class MainClass
{

    public static void Main()
    {
        Car myCar = new Car("Toyota", "MR2", "black", 1995);
        Car myCar2 = new Car();
        Car myCar3 = new Car("Chevrolet");

        System.Console.WriteLine("myCar details:");
        myCar.Display();
        System.Console.WriteLine("myCar2 details:");
        myCar2.Display();
        System.Console.WriteLine("myCar3 details:");
        myCar3.Display();
    }
}

//myCar details:
//make = Toyota
//model = MR2
//color = black
//yearBuilt = 1995
//myCar2 details:
//make = Ford
//model = Mustang
//color = red
//yearBuilt = 1970
//myCar3 details:
//make = Chevrolet
//model = Corvette
//color = silver
//yearBuilt = 1969
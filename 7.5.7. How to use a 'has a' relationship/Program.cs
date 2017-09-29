using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    public int cylinders;
    public int horsepower;

    public void Start()
    {
        System.Console.WriteLine("Engine started");
    }

}

public class Car
{
    public string make;
    public Engine engine;  // Car has an Engine

    public void Start()
    {
        engine.Start();
    }

}

class MainClass
{

    public static void Main()
    {
        System.Console.WriteLine("Creating a Car object");
        Car myCar = new Car();
        myCar.make = "Toyota";

        System.Console.WriteLine("Creating an Engine object");
        myCar.engine = new Engine();
        myCar.engine.cylinders = 4;
        myCar.engine.horsepower = 180;

        System.Console.WriteLine("myCar.make = " + myCar.make);
        System.Console.WriteLine("myCar.engine.cylinders = " + myCar.engine.cylinders);
        System.Console.WriteLine("myCar.engine.horsepower = " + myCar.engine.horsepower);

        myCar.Start();
    }
}
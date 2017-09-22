using System;
class House
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

        myHouse = new House();

        myHouse.Start();
        myHouse.Stop();


        House yourHouse = new House();
        yourHouse.make = "AQW";
        yourHouse.model = "SSS";
        yourHouse.color = "red";
        yourHouse.yearBuilt = 2000;
        System.Console.WriteLine("yourHouse is a " + yourHouse.model);

    }

}

//started
// stopped
//yourHouse is a SSS
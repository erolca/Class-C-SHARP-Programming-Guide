using System;
//7.3.7.	Change the object referenced by the myHouse object reference to the object
//referenced by yourHouse
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
        yourHouse.make = "AAA";
        yourHouse.model = "VVV";
        yourHouse.color = "red";
        yourHouse.yearBuilt = 2000;
        System.Console.WriteLine("yourHouse is a " + yourHouse.model);


        System.Console.WriteLine("Assigning yourHouse to myHouse");
        myHouse = yourHouse;
        System.Console.WriteLine("myHouse details:");
        System.Console.WriteLine("myHouse.make = " + myHouse.make);
        System.Console.WriteLine("myHouse.model = " + myHouse.model);
        System.Console.WriteLine("myHouse.color = " + myHouse.color);
        System.Console.WriteLine("myHouse.yearBuilt = " + myHouse.yearBuilt);

    }
}
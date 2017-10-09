using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//7.12.1.	Assign null to myHouse (myHouse will no longer reference an object)
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
        myHouse = null;
    }
}
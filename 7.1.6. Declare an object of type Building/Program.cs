using System;

class Building
{
    public int floors;
    public int area;
    public int occupants;
}


class BuildingDemo
{
    public static void Main()
    {
        Building house = new Building(); // create a Building object 
        int areaPP;

        house.occupants = 4;
        house.area = 2500;
        house.floors = 2;

        areaPP = house.area / house.occupants;

        Console.WriteLine("house has:\n  " +
                          house.floors + " floors\n  " +
                          house.occupants + " occupants\n  " +
                          house.area + " total area\n  " +
                          areaPP + " area per person");
    }
}
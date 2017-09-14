using System;

class Building
{
    public int area;
    public int occupants;
}

class BuildingDemo
{
    public static void Main()
    {
        Building house = new Building();
        Building office = new Building();

        int areaPP; // area per person 

        house.occupants = 4;
        house.area = 2500;

        office.occupants = 25;
        office.area = 4200;

        areaPP = house.area / house.occupants;

        Console.WriteLine("house has:\n  " +
                          house.occupants + " occupants\n  " +
                          house.area + " total area\n  " +
                          areaPP + " area per person");

        Console.WriteLine();

        areaPP = office.area / office.occupants;

        Console.WriteLine("office has:\n  " +
                          office.occupants + " occupants\n  " +
                          office.area + " total area\n  " +
                          areaPP + " area per person");
    }
}

//house has:
//  4 occupants
//  2500 total area
//  625 area per person

//office has:
//  25 occupants
//  4200 total area
//  168 area per person
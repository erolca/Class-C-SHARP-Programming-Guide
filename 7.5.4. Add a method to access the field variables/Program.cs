using System;

class Building
{
    public int area;
    public int occupants;


    public void areaPerPerson()
    {
        Console.WriteLine("Display the area per person.");
        Console.WriteLine("  " + area / occupants +
                          " area per person");
    }
}

class BuildingDemo
{
    public static void Main()
    {
        Building house = new Building();
        Building office = new Building();

        house.occupants = 4;
        house.area = 2500;

        // assign values to fields in office 
        office.occupants = 25;
        office.area = 4200;

        Console.WriteLine("house has:\n  " +
                          house.occupants + " occupants\n  " +
                          house.area + " total area");
        house.areaPerPerson();

        Console.WriteLine();

        Console.WriteLine("office has:\n  " +
                          office.occupants + " occupants\n  " +
                          office.area + " total area");
        office.areaPerPerson();
    }
}
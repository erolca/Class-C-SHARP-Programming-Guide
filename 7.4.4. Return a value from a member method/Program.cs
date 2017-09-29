using System;

class Building
{
    public int area;
    public int occupants;

    // Return the area per person.  
    public int areaPerPerson()
    {
        return area / occupants;
    }
}

class MainClass
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

        areaPP = house.areaPerPerson();

        Console.WriteLine("house has:\n  " +
                          house.occupants + " occupants\n  " +
                          house.area + " total area\n  " +
                          areaPP + " area per person");


        Console.WriteLine();

        // obtain area per person for office 
        areaPP = office.areaPerPerson();

        Console.WriteLine("office has:\n  " +
                          office.occupants + " occupants\n  " +
                          office.area + " total area\n  " +
                          areaPP + " area per person");
    }
}
using System;

class Building
{
    public int floors;
    public int area;
    public int occupants;


    public Building(int f, int a, int o)
    {
        floors = f;
        area = a;
        occupants = o;
    }

    public int areaPerPerson()
    {
        return area / occupants;
    }

    public int maxOccupant(int minArea)
    {
        return area / minArea;
    }
}

class MainClass
{
    public static void Main()
    {
        Building house = new Building(2, 2500, 4);
        Building office = new Building(3, 4200, 25);

        Console.WriteLine("Maximum occupants for house if each has " +
                          300 + " square feet: " +
                          house.maxOccupant(300));

        Console.WriteLine("Maximum occupants for office if each has " +
                          300 + " square feet: " +
                          office.maxOccupant(300));
    }
}

//Maximum occupants for house if each has 300 square feet: 8
//Maximum occupants for office if each has 300 square feet: 14
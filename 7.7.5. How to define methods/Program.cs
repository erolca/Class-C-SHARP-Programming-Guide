using System;

//7.7.5.	How to define methods that return a value and accept parameters

class Car
{
    public int yearBuilt;
    public double maximumSpeed;

    public int Age(int currentYear)
    {
        int age = currentYear - yearBuilt;
        return age;
    }

    public double Distance(double initialSpeed, double time)
    {
        return (initialSpeed + maximumSpeed) / 2 * time;
    }

}

class MainClass
{

    public static void Main()
    {
        Car myCar = new Car();

        myCar.yearBuilt = 2000;
        myCar.maximumSpeed = 150;

        int age = myCar.Age(2001);
        System.Console.WriteLine("myCar is " + age + " year old.");
        System.Console.WriteLine("myCar travels " + myCar.Distance(31, .25) + " miles.");

    }

}
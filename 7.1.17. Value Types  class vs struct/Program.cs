using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        TemperatureStruct ts = new TemperatureStruct();     //-< structer
        TemperatureStruct tp = new TemperatureStruct();     //-< structer
        TemperatureClass tc = new TemperatureClass();       //-< class

        Console.Write("Enter degrees in Celsius: ");
        string celsius = Console.ReadLine();
        ts.Celsius = Convert.ToDouble(celsius);

        Console.WriteLine("Temperature in Fahrenheit = {0}", ts.Fahrenheit);
    }
}

class TemperatureClass
{
    private double degreesCelsius;
    public double Fahrenheit
    {
        get
        {
            return ((9d / 5d) * degreesCelsius) + 32;
        }
        set
        {
            degreesCelsius = (5d / 9d) * (value - 32);
        }
    }
    public double Celsius
    {
        get
        {
            return degreesCelsius;
        }
        set
        {
            degreesCelsius = value;
        }
    }
}

struct TemperatureStruct
{
    public double Celsius;

    public double Fahrenheit
    {
        get
        {
            return ((9d / 5d) * Celsius) + 32;
        }
        set
        {
            Celsius = (5d / 9d) * (value - 32);
        }
    }
}
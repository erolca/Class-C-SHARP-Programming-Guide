using System;

class Address
{
    protected string city;
    public string City
    {
        get { return city; }
    }

    protected string zipCode;

    public string ZipCode
    {
        get { return zipCode; }
        set
        {
            zipCode = value;
            city = "Atlanta";
        }
    }
}

class PropertyApp
{
    public static void Main()
    {
        Address addr = new Address();
        addr.ZipCode = "30338";
        string zip = addr.ZipCode;

        Console.WriteLine("The city for ZIP code {0} is {1}", addr.ZipCode, addr.City);
    }
}
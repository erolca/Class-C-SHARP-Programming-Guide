using System;

public class HelloWorld
{
    public static void Main()
    {
        Person hs = new Person();
        hs.Name = "Your name";
        hs.Address = "Your address";
        Console.WriteLine(hs.GetName());
        Console.WriteLine(hs.GetAddress());
    }
}
public interface IName
{
    string GetName();
}


public interface IAddress
{
    string GetAddress();
}


public class Person : IName, IAddress
{
    private string name, address;

    public Person()
    {
    }
    public string Name
    {
        set
        {
            name = value;
        }
    }
    public string Address
    {
        set
        {
            address = value;
        }
    }
    public string GetName()
    {
        return name;
    }
    public string GetAddress()
    {
        return address;
    }
}
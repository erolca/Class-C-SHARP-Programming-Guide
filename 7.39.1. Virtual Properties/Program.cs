using System;

public abstract class Employee
{
    public abstract string Name
    {
        get;
    }
}
class Engineer : Employee
{
    string name = "Engineer";

    public override string Name
    {
        get
        {
            return (name);
        }
    }
}
class MainClass
{
    public static void Main()
    {
        Employee d = new Engineer();
        Console.WriteLine("Name: {0}", d.Name);
        
    }
}

//Name: Engineer
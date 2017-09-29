using System;

class Employee
{

    //fields...
    private string name;
    protected float billingRate;

    // constructor
    public Employee(string name, float billingRate)
    {
        this.name = name;
        this.billingRate = billingRate;
    }
    // figure out the charge based on Employee's rate
    public float CalculateCharge(float hours)
    {
        return (hours * billingRate);
    }
    // return the name of this type
    public string TypeName()
    {
        return ("Employee");
    }

    
}
class MainClass
{
    public static void Main()
    {
        Employee Employee = new Employee("A", 21.20F);
        Console.WriteLine("Name is: {0}", Employee.TypeName());
    }
}
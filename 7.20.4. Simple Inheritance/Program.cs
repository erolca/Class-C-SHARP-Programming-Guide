using System;

class Employee
{
    public Employee(string name, float billingRate)
    {
        this.name = name;
        this.billingRate = billingRate;
    }

    public float CalculateCharge(float hours)
    {
        return (hours * billingRate);
    }

    public string TypeName()
    {
        return ("Employee");
    }

    private string name;
    protected float billingRate;
}

class Manager : Employee
{
    public Manager(string name, float billingRate) : base(name, billingRate)
    {
    }
    public new float CalculateCharge(float hours)
    {
        if (hours < 1.0F)
            hours = 1.0F;
        return (hours * billingRate);
    }

    public new string TypeName()
    {
        return ("Civil Employee");
    }
}
class Test
{
    public static void Main()
    {
        Employee e = new Employee("A", 15.50F);
        Manager c = new Manager("B", 40F);

        Console.WriteLine("{0} charge = {1}", e.TypeName(), e.CalculateCharge(2F));
        Console.WriteLine("{0} charge = {1}", c.TypeName(), c.CalculateCharge(0.75F));
    }
}
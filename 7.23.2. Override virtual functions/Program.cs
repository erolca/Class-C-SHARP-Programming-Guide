using System;

class Employee
{
    public Employee(string name, float billingRate)
    {
        this.name = name;
        this.billingRate = billingRate;
    }
    // function now virtual
    virtual public float CalculateCharge(float hours)
    {
        return (hours * billingRate);
    }
    // function now virtual
    virtual public string TypeName()
    {
        return ("Employee");
    }

    private string name;
    protected float billingRate;
}

class Manager : Employee
{
    public Manager(string name, float billingRate) :  base(name, billingRate)
    {
    }
    // overrides function in Employee
    override public float CalculateCharge(float hours)
    {
        if (hours < 1.0F)
            hours = 1.0F;        // minimum charge.
        return (hours * billingRate);
    }

    // overrides function in Employee
    override public string TypeName()
    {
        return ("Civil Employee");
    }
}
class Test
{
    public static void Main()
    {
        Employee[] earray = new Employee[2];
        earray[0] = new Employee("A", 15.50F); // çok biçimlilik 
        earray[1] = new Manager("B", 40F);     // çok biçimlilik

        Console.WriteLine("{0} charge = {1}",
        earray[0].TypeName(),
        earray[0].CalculateCharge(2F));
        Console.WriteLine("{0} charge = {1}",
        earray[1].TypeName(),
        earray[1].CalculateCharge(0.75F));
    }
}

//Employee charge = 31
//Civil Employee charge = 40
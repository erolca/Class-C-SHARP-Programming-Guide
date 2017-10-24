using System;

abstract class Employee
{
    public Employee(string name, float billingRate)
    {
        this.name = name;
        this.billingRate = billingRate;
    }

    virtual public float CalculateCharge(float hours)
    {
        return (hours * billingRate);
    }

    abstract public string TypeName();

    private string name;
    protected float billingRate;
}

class Manager : Employee
{
    
    public Manager(string name, float billingRate) : base(name, billingRate)
    {
    }
    
    override public float CalculateCharge(float hours)
    {
        if (hours < 1.0F)
            hours = 1.0F;        // minimum charge.
  
        return (hours * billingRate);
    }

    // This override is required, or an error is generated.
    override public string TypeName()
    {
        return ("Manager");
    }
}

class Clerk : Employee
{
    public Clerk(string name, float billingRate) :
    base(name, billingRate)
    {
    }

    override public string TypeName()
    {
        return ("Clerk");
    }
}
class Test
{
    public static void Main()
    {
        Employee[] earray = new Employee[2];
        earray[0] = new Manager("A", 40.0F); // upcast
        earray[1] = new Clerk("C", 45.0F);

        Console.WriteLine("{0} charge = {1}",
        earray[0].TypeName(),
        earray[0].CalculateCharge(2F));

        Console.WriteLine("{0} charge = {1}",
        earray[1].TypeName(),
        earray[1].CalculateCharge(0.75F));
    }
}
//Manager charge = 80
//Clerk charge = 33.75
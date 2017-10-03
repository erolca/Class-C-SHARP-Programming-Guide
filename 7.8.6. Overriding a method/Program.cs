using System;
public class Employee
{
    private int fAge;

    public Employee()
    {
        fAge = 21;
    }
    public virtual void setAge(int age)
    {
        fAge = age;
    }
    public virtual int getAge()
    {
        return fAge;
    }
}

public class AdultEmployee : Employee
{
    public AdultEmployee()
    {
    }
    override public void setAge(int age)
    {
        if (age > 21)
            base.setAge(age);
    }
}

class MainClass
{
    public static void Main()
    {
        Employee p = new Employee();
        p.setAge(18);
        AdultEmployee ap = new AdultEmployee();
        ap.setAge(18);
        Console.WriteLine("Employee Age: {0}", p.getAge());
        Console.WriteLine("AdultEmployee Age: {0}", ap.getAge());
    }
}
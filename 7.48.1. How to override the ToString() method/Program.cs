using System;

public class Employee
{
    public string firstName;
    public string lastName;

    public Employee(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public override string ToString()
    {
        return firstName + " " + lastName;
    }
}

class MainClass
{
    public static void Main()
    {
        Employee myEmployee = new Employee("A", "M");
        Employee myOtherEmployee = new Employee("B", "N");

        Console.WriteLine("myEmployee.ToString() = " + myEmployee.ToString());
        Console.WriteLine("myOtherEmployee.ToString() = " + myOtherEmployee.ToString());
    }
}

//myEmployee.ToString() = A M
//myOtherEmployee.ToString() = B N
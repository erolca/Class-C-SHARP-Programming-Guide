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

    public void Display()
    {
        Console.WriteLine("firstName = " + firstName);
        Console.WriteLine("lastName = " + lastName);
    }

    public static Employee Copy(Employee Employee)
    {
        
        return (Employee)Employee.MemberwiseClone();
    }
}


class MainClass
{

    public static void Main()
    {
        Console.WriteLine("Creating Employee objects");
        Employee myEmployee = new Employee("A", "M");
        Employee myOtherEmployee = new Employee("B", "N");
        Console.WriteLine("myEmployee details:");
        myEmployee.Display();
        Console.WriteLine("myOtherEmployee details:");
        myOtherEmployee.Display();


        Console.WriteLine("Performing a memberwise clone of myEmployee to myOldEmployee");
        Employee myOldEmployee = Employee.Copy(myEmployee);
        Console.WriteLine("myOldEmployee details:");
        myOldEmployee.Display();
    }
}
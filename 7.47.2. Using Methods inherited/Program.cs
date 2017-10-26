using System;

//7.47.2.	Using Methods inherited from the System.Object class: ToString, GetType, GetHashCode, Equals, ReferenceEquals

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


        Console.WriteLine("myEmployee.ToString() = " + myEmployee.ToString());
        Console.WriteLine("myEmployee.GetType() = " + myEmployee.GetType());
        Console.WriteLine("myEmployee.GetHashCode() = " + myEmployee.GetHashCode());
        Console.WriteLine("Employee.Equals(myEmployee, myOtherEmployee) = " + Employee.Equals(myEmployee, myOtherEmployee));
        Console.WriteLine("Employee.ReferenceEquals(myEmployee, myOtherEmployee) = " + Employee.ReferenceEquals(myEmployee, myOtherEmployee));

    }

}
//Creating Employee objects
//myEmployee details:
//firstName = A
//lastName = M
//myOtherEmployee details:
//firstName = B
//lastName = N
//myEmployee.ToString() = Employee
//myEmployee.GetType() = Employee
//myEmployee.GetHashCode() = 58225482
//Employee.Equals(myEmployee, myOtherEmployee) = False
//Employee.ReferenceEquals(myEmployee, myOtherEmployee) = False
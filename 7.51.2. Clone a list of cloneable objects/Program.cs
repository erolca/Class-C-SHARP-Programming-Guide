using System;
using System.Text;
using System.Collections.Generic;

public class Employee : ICloneable
{
    public string Name;
    public string Title;
    public int Age;

    public Employee(string name, string title, int age)
    {
        Name = name;
        Title = title;
        Age = age;
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public override string ToString()
    {
        return string.Format("{0} ({1}) - Age {2}", Name, Title, Age);
    }
}

public class EmployeeList : ICloneable
{
    public List<Employee> EmployeeListMembers = new List<Employee>();

    public EmployeeList()
    {
    }

    private EmployeeList(List<Employee> members)
    {
        foreach (Employee e in members)
        {
            EmployeeListMembers.Add((Employee)e.Clone());
        }
    }

    public void AddMember(Employee member)
    {
        EmployeeListMembers.Add(member);
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();

        foreach (Employee e in EmployeeListMembers)
        {
            str.AppendFormat("  {0}\r\n", e);
        }

        return str.ToString();
    }

    public object Clone()
    {
        return new EmployeeList(this.EmployeeListMembers);
    }
}

public class MainClass
{
    public static void Main()
    {
        EmployeeList team = new EmployeeList();
        team.AddMember(new Employee("A", "AA", 4));
        team.AddMember(new Employee("B", "BB", 8));
        team.AddMember(new Employee("C", "CC", 8));

        EmployeeList clone = (EmployeeList)team.Clone();

        Console.WriteLine("Original EmployeeList:");
        Console.WriteLine(team);

        Console.WriteLine("Clone EmployeeList:");
        Console.WriteLine(clone);

        Console.WriteLine("*** Make a change to original team ***");
        team.EmployeeListMembers[0].Name = "L";
        team.EmployeeListMembers[0].Title = "M";
        team.EmployeeListMembers[0].Age = 4;

        Console.WriteLine("Original EmployeeList:");
        Console.WriteLine(team);

        Console.WriteLine("Clone EmployeeList:");
        Console.WriteLine(clone);
    }
}


//Original EmployeeList:
//  A(AA) - Age 4
//  B(BB) - Age 8
//  C(CC) - Age 8

//Clone EmployeeList:
//  A(AA) - Age 4
//  B(BB) - Age 8
//  C(CC) - Age 8

//*** Make a change to original team***
//Original EmployeeList:
//  L(M) - Age 4
//  B(BB) - Age 8
//  C(CC) - Age 8

//Clone EmployeeList:
//  A(AA) - Age 4
//  B(BB) - Age 8
//  C(CC) - Age 8
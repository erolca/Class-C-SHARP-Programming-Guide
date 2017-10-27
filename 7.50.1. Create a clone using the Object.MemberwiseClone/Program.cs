using System;
using System.Text;
using System.Collections.Generic;

//7.50.1.	Create a clone using the Object.MemberwiseClone method because the Employee class contains only string and value types

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

public class MainClass
{
    public static void Main()
    {
        Employee em = new Employee("A", "AA", 4);

        Employee cloneEmployee = (Employee)em.Clone();

        Console.WriteLine("Original Employee:");
        Console.WriteLine(em);

        Console.WriteLine("Clone Employee:");
        Console.WriteLine(cloneEmployee);

        Console.WriteLine("*** Make a change to original employee ***");
        em.Name = "L";
        em.Title = "M";
        em.Age = 4;

        Console.WriteLine("Original Employee:");
        Console.WriteLine(em);

        Console.WriteLine("Clone Employee:");
        Console.WriteLine(cloneEmployee);
    }
}
//Original Employee:
//A(AA) - Age 4
//Clone Employee:
//A(AA) - Age 4
//*** Make a change to original employee***
//Original Employee:
//L(M) - Age 4
//Clone Employee:
//A(AA) - Age 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Student : ICloneable
{

    public Student(string name, string lastName, int weight)
    {
        Name = name;
        LastName = lastName;
        Weight = weight;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public int Weight { get; set; }

    public override string ToString()
    {
        return string.Format("{0} [Name={1} LastName={2} Weight={3}]", GetType(), Name, LastName, Weight);
    }

    public object Clone()
    {
        return new Student(Name, LastName, Weight);
    }

}

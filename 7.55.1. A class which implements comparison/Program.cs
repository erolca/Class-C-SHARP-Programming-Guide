using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

class Person : IComparable<Person>, IEquatable<Person>, IComparable
{
    public string Name;
    public int Age;
    public string Company;

    // Implements IComparable<Person>.CompareTo:
    public int CompareTo(Person other)
    {
        if (other == null)
            return -1;
        return this.Name.CompareTo(other.Name);
    }

    // Implements IComparable.CompareTo:
    public int CompareTo(object obj)
    {
        Person p = obj as Person;
        return CompareTo(p);
    }

    // Implements IEquatable<Person>.Equals:
    public bool Equals(Person other)
    {
        return ((IComparable<Person>)this).CompareTo(other) == 0;
    }

    // Overrides Object.Equals:
    public override bool Equals(object obj)
    {
        Person p = obj as Person;
        return Equals(p);
    }
}

public class MainClass
{
    public static void Main()
    {
        Person[] people = new Person[3];
        people[0] = new Person();
        people[0].Name = "S D"; people[0].Age = 20; people[0].Company = "E";
        people[1] = new Person();
        people[1].Name = "M M"; people[1].Age = 40; people[1].Company = "C";
        people[2] = new Person();
        people[2].Name = "J D"; people[2].Age = 30; people[2].Company = "T";

        foreach (Person p in people)
            Console.Write("'{0},{1},{2}'\t", p.Name, p.Age, p.Company);
        Console.WriteLine();

        Array.Sort(people);

        foreach (Person p in people)
            Console.Write("'{0},{1},{2}'\t", p.Name, p.Age, p.Company);
    }
}

//'S D,20,E'      'M M,40,C'      'J D,30,T'
//'J D,30,T'      'M M,40,C'      'S D,20,E'
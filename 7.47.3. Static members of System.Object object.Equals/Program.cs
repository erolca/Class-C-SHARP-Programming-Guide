using System;
using System.Text;

class Person
{
    public Person(string fname, string lname, string ssn, byte a)
    {
        FirstName = fname;
        LastName = lname;
        SSN = ssn;
        age = a;
    }

    public string FirstName;
    public string LastName;
    public string SSN;
    public byte age;

    public override bool Equals(object o)
    {
        Person temp = (Person)o;
        if (temp.FirstName == this.FirstName &&
           temp.LastName == this.LastName &&
           temp.SSN == this.SSN &&
           temp.age == this.age)
        {
            return true;
        }
        else
            return false;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("[FirstName= {0}", this.FirstName);
        sb.AppendFormat(" LastName= {0}", this.LastName);
        sb.AppendFormat(" SSN= {0}", this.SSN);
        sb.AppendFormat(" Age= {0}]", this.age);

        return sb.ToString();
    }

    public override int GetHashCode()
    {
        return SSN.GetHashCode();
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("A", "B", "222-22-2222", 98);
        Person p2 = new Person("A", "B", "222-22-2222", 98);

        Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p1, p2));
        Console.WriteLine(p1.ToString());
    }
}
//P3 and P4 have same state: True
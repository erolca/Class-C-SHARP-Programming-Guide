using System;
using System.Text;
using System.Collections.Generic;

//7.50.1.	Create a clone using the Object.MemberwiseClone method because the Employee class contains only string and value types

public class Employee : ICloneable
{
    public string Name;
    public string Title;
    public int Age;
    public Employee()
    {

    }

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



    // Derin kopyalama....
    public object Kopyala()
    {
        return this.Clone();
    }

    public Employee Kopyala2()
    {
        Employee Temp = new Employee();
        Temp.Name = this.Name;
        return Temp;

    }

    public override string ToString()
    {
        
        return string.Format("{0} ({1}) - Age {2}", Name, Title, Age);
    }
}

// Define a value type that does not override Equals.
public struct Person
{
    private string personName;

    public Person(string name)
    {
        this.personName = name;
    }

    public override string ToString()
    {
        return this.personName;
    }
}


public class MainClass
{
    public static void Main()
    {

        Person person1 = new Person("John");
        Person person2 = new Person("John");

        Console.WriteLine("Calling Equals:");
        Console.WriteLine(person1.Equals(person2));

        Console.WriteLine("\nCasting to an Object and calling Equals:");
        Console.WriteLine(((object)person1).Equals((object)person2));


        Employee em = new Employee("A", "AA", 4);
        Employee emx = new Employee("A", "AA", 4);// (Employee) em.Kopyala(); // Deep Copy
        Employee emd = em;
        
        Employee emxd = em.Kopyala2();          //Deep Copy

       

        Console.WriteLine("em and emx are pointing to same object: {0}", object.ReferenceEquals(em, emx));
        Console.WriteLine("em and emx have same state: {0}", object.Equals(em, emx)); // Equals overrride edilmeli....
        Console.WriteLine(em.Equals(emx));
        Console.WriteLine(((object)em).Equals((object)emx));

        /* emx=new Employee("A", "AA", 4);
        Console.WriteLine(((object)emx).Equals((object)em));*/




        Employee cloneEmployee = (Employee)em.Clone();//Shallow copy Sığ kopyalama
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


        //
        //Console.WriteLine("em and cloneEmployee are pointing to same object: {0}", object.ReferenceEquals(em, cloneEmployee));
        //Console.WriteLine("em and cloneEmployee have same state: {0}", object.Equals(em, cloneEmployee));




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
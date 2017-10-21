using System;

class Person
{
    public string fullName;
    public int age;

    public Person(string n, int a)
    {
        fullName = n;
        age = a;
    }

    public void PrintInfo()
    {
        Console.WriteLine("{0} is {1} years old", fullName, age);
    }
}

class MainClass
{
    public static void SendAPersonByReference(ref Person p)
    {
        p.age = 555;

        p = new Person("TOM", 999);
    }


    public static void Main()
    {
        Person mel = new Person("Mel", 23);
        mel.PrintInfo();
        SendAPersonByReference(ref mel);
        mel.PrintInfo();
    }
}

//Mel is 23 years old
//TOM is 999 years old
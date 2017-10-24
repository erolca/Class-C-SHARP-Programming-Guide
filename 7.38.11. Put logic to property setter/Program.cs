using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    private string _lastname;
    private string _firstname;

    public void SetName(string lastname, string firstname)
    {
        _lastname = lastname;
        _firstname = firstname;
    }
    public string FullName
    {
        get
        {
            return _firstname + " " + _lastname;
        }
        set
        {
            string[] names = value.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            _firstname = names[0];
            _lastname = names[names.Length - 1];

        }
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.SetName("A", "B");

        Console.WriteLine("The person's full name is {0}", person.FullName);
        person.FullName = "A b c";
        Console.WriteLine("The person's full name is {0}", person.FullName);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class MyClass
{
    public readonly string Name;
    private int intVal;

    public int Val
    {
        get
        {
            return intVal;
        }
        set
        {
            if (value >= 0 && value <= 10)
                intVal = value;
            else
                throw (new /*ArgumentOutOfRangeException*/ MyException("Val : "+ value + " ->Val must be assigned a value between 0 and 10."));
        }
    }
    public override string ToString()
    {
        return "Name: " + Name + "\nVal: " + Val;
    }

    private MyClass() : this("Default Name")
    {
    }
    public MyClass(string newName)
    {
        Name = newName;
        intVal = 0;
    }
}


public class MyException : Exception
{
    public MyException(String msg) : base(msg)
    {
   
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObj = new MyClass("My Object");
        Console.WriteLine("myObj created.");
        for (int i = -1; i <= 0; i++)
        {
            try
            {
                myObj.Val = i;
            }
            catch (/*Exception*/ MyException e)
            {
                Console.WriteLine("Exception {0} thrown.", e.GetType().FullName);
                Console.WriteLine("Message:\n\"{0}\"", e.Message);
                //}
            }
        }
    }
}
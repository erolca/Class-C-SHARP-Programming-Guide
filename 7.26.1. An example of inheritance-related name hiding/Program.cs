using System;

class BaseClass
{
    public int i = 0;
}

// Create a derived class. 
class DerivedClass : BaseClass
{
    new int i; // this i hides the i in BaseClass 

    public DerivedClass(int b)
    {
        i = b; // i in DerivedClass 
    }

    public void show()
    {
        Console.WriteLine("i in derived class: " + i);
        Console.WriteLine("i in base class: " + base.i);
    }
}

class MainClass
{
    public static void Main()
    {
        DerivedClass ob = new DerivedClass(2);

        ob.show();
    }
}

//i in derived class: 2
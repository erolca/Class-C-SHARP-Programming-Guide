using System;

class BaseClass
{
    public int i = 0;
}

// Create a derived class. 
class DerivedClass : BaseClass
{
    new int i; // this i hides the i in BaseClass 

    public DerivedClass(int a, int b)
    {
        base.i = a; // this uncovers the i in BaseClass 
        i = b; // i in DerivedClass 
    }

    public void show()
    {
        // this displays the i in BaseClass. 
        Console.WriteLine("i in base class: " + base.i);

        // this displays the i in DerivedClass 
        Console.WriteLine("i in derived class: " + i);
    }
}

class MainClass
{
    public static void Main()
    {
        DerivedClass ob = new DerivedClass(1, 2);

        ob.show();
    }
}
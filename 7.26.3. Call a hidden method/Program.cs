using System;

class BaseClass
{
    public int i = 0;

    // show() in BaseClass 
    public void show()
    {
        Console.WriteLine("i in base class: " + i);
    }
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

    // This hides show() in BaseClass. Notice the use of new. 
    new public void show()
    {
        base.show(); // this calls show() in BaseClass 

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

//i in base class: 1
//i in derived class: 2
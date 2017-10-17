using System;

//A protected member is public within a class hierarchy, but private outside that hierarchy.
//A protected member is created by using the protected access modifier.

class BaseClass
{
    protected int i, j; // private to BaseClass, but accessible by D 

    public void set(int a, int b)
    {
        i = a;
        j = b;
    }

    public void show()
    {
        Console.WriteLine(i + " " + j);
    }
}

class DerivedClass : BaseClass
{
    int k; // private 

    // DerivedClass can access BaseClass's i and j 
    public void setk()
    {
        k = i * j;
    }

    public void showk()
    {
        Console.WriteLine(k);
    }
}

class MainClass
{
    public static void Main()
    {
        DerivedClass ob = new DerivedClass();

        ob.set(2, 3); // OK, known to DerivedClass 
        ob.show();    // OK, known to DerivedClass 

        ob.setk();  // OK, part of DerivedClass 
        ob.showk(); // OK, part of DerivedClass 
    }
}
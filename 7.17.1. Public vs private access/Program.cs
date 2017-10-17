using System;

class MyClass
{
    private int a; // private access explicitly specified 
    int b;          // private access by default 
    public int gamma;  // public access 

    public void setAlpha(int val)
    {
        a = val;
    }

    public int getAlpha()
    {
        return a;
    }

    public void setBeta(int a)
    {
        b = a;
    }

    public int getBeta()
    {
        return b;
    }
}

class AccessDemo
{
    public static void Main()
    {
        MyClass ob = new MyClass();

        /* Access to a and b is allowed only through methods. */
        ob.setAlpha(-99);
        ob.setBeta(19);
        Console.WriteLine("ob.a is " + ob.getAlpha());
        Console.WriteLine("ob.b is " + ob.getBeta());

        // You cannot access a or b like this: 
        //  ob.a = 10; // Wrong! a is private! 
        //  ob.b = 9;   // Wrong! b is private! 

        // It is OK to directly access gamma because it is public. 
        ob.gamma = 99;
    }
}
using System;
/*
 There are several restrictions that apply to static methods:

    1-  A static method does not have a this reference.
    2-  A static method can directly call only other static methods.
    3-  A static method cannot directly call an instance method of its class.
    4-  A static method must directly access only static data.
    5-  You can't directly access a non-static variable from within a static method.
    6-  You can't directly call a non-static method from within a static method.
*/


class StaticDemo
{
    // a static variable 
    public static int val = 100;

    // a static method 
    public static int valDiv2()
    {
        return val / 2;
    }
}

class MainClass
{
    public static void Main()
    {

        Console.WriteLine("Initial value of StaticDemo.val is " + StaticDemo.val);

        StaticDemo.val = 8;
        Console.WriteLine("StaticDemo.val is " + StaticDemo.val);
        Console.WriteLine("StaticDemo.valDiv2(): " + StaticDemo.valDiv2());
    }
}

//Initial value of StaticDemo.val is 100
//StaticDemo.val is 8
//StaticDemo.valDiv2(): 4
using System;

interface MyInterface
{
    bool MyMethodA(int x);
    bool MyMethodB(int x);
}

class MyClass : MyInterface
{

    // Explicit implementation. 
    bool MyInterface.MyMethodA(int x)
    {
        if ((x % 2) != 0)
            return true;
        else
            return false;
    }

    // Normal implementation. 
    public bool MyMethodB(int x)
    {
        MyInterface o = this; // reference to invoking object 

        return !o.MyMethodA(x);
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass ob = new MyClass();
        bool result;

        result = ob.MyMethodB(4);
        if (result) Console.WriteLine("4 is even.");

        // result = ob.MyMethodA(4); // Error, MyMethodA not directly accessible 
        result = !((MyInterface)ob).MyMethodA(4); // 

        MyInterface iRef = (MyInterface)ob; //upcast ->MyInterface o = this
        result = iRef.MyMethodA(3);
        if (result) Console.WriteLine("3 is odd.");

    }
}

//4 is even.
//3 is odd.
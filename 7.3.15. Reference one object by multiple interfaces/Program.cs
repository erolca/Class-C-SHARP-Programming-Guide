using System;

interface Interface1
{
    void PrintOut(string s);
}

interface Interface2
{
    void PrintOut(string s);
}

class MyClass : Interface1, Interface2
{
    public void PrintOut(string s)
    {
        Console.WriteLine(s);
    }
}

class MainClass
{
    static void Main()
    {
        MyClass mc = new MyClass();
        Interface1 ifc1 = (Interface1)mc;
        Interface2 ifc2 = (Interface2)mc;

        mc.PrintOut("object.");
        ifc1.PrintOut("interface 1.");
        ifc2.PrintOut("interface 2.");
    }
}
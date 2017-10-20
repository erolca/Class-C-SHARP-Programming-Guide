using System;

class MainClass
{
    static void Main(string[] args)
    {
        B MyB = new C(); // not: C-> B den kalıtım almıştır...

        MyB.Display();
    }
}
//Class C's Display Method

abstract class A
{
    public abstract void Display();
}

class B : A
{
    public override void Display()
    {
        Console.WriteLine("Class B's Display Method");
    }
}
class C : B
{
    public override void Display()  
    {
        Console.WriteLine("Class C's Display Method");
    }
}
class D : C
{
    public override void Display()
    {
        Console.WriteLine("Class D's Display Method");
    }
}
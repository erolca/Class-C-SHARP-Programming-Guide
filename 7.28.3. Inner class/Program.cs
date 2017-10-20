using System;

class MyClass
{
    class MyCounter
    {
        public int Count = 0;
    }

    private MyCounter counter;

    public MyClass()
    {
        counter = new MyCounter();
    }
    public int Incr()
    {
        return counter.Count++;
    }
    public int GetValue()
    {
        return counter.Count;
    }
}

class MainClass
{
    static void Main()
    {
        MyClass mc = new MyClass();

        mc.Incr();
        mc.Incr();
        mc.Incr();
        mc.Incr();
        mc.Incr();
        mc.Incr();

        Console.WriteLine("Total: {0}", mc.GetValue());
    }
}
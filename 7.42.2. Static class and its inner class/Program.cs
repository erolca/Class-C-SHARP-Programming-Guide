using System;

public static class StaticClass
{
    public static void DoWork()
    {
        ++CallCount;
        Console.WriteLine("StaticClass.DoWork()");
    }

    public class NestedClass
    {
        public NestedClass()
        {
            Console.WriteLine("NestedClass.NestedClass()");
        }
    }

    public static long CallCount = 0;
}

public static class MainClass
{
    static void Main()
    {
        StaticClass.DoWork();

        StaticClass.NestedClass nested = new StaticClass.NestedClass();

        Console.WriteLine("CallCount = {0}", StaticClass.CallCount);
    }
}
//StaticClass.DoWork()
//NestedClass.NestedClass()
//CallCount = 1
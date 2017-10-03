using System;

class MainClass
{
    public static void PrintParams(params object[] list)
    {
        for (int i = 0; i < list.Length; ++i)
            Console.WriteLine("Object {0} = {1} ({2})", i, list[i], list[i].GetType());
    }

    public static void Main()
    {
        PrintParams(1, 2, "a", "b", 23.4);
    }
}
using System;

class Constants
{
    public const int value1 = 33;
    public const string value2 = "Hello";
}
class MainClass
{
    public static void Main()
    {
        Console.WriteLine("{0} {1}",
        Constants.value1,
        Constants.value2);
    }
}
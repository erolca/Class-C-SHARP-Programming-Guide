using System.ComponentModel;

public class MainClass
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    private static int InstanceCounter { get; set; }
    private static readonly object counterLock = new object();

    public MainClass(string name, int age)
    {
        Name = name;
        Age = age;

        lock (counterLock)
        {
            InstanceCounter++;
        }
    }
}

class MyClass
{
    static void Main()
    {
        MainClass d = new MainClass("Bob", 25);

       

    }
}
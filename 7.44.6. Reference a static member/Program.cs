

public class Employee
{
    public Employee()
    {
        totalHeadCount = 123;
        Employee.totalHeadCount = 456;
    }

    public static int totalHeadCount;
}

public class MainClass
{
    static void Main()
    {
        Employee bob = new Employee();

        System.Console.WriteLine("Static Field Employee.totalHeadCount is {0}", Employee.totalHeadCount);

    }
}
//Static Field Employee.totalHeadCount is 456
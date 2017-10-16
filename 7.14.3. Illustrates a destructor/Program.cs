public class Car
{
    ~Car()
    {
        System.Console.WriteLine("In ~Car() destructor");
    }

}

class MainClass
{

    public static void Main()
    {
        Car myCar = new Car();

        System.Console.WriteLine("At the end of Main()");
    }

}

/*
 At the end of Main()
In ~Car() destructor

 */

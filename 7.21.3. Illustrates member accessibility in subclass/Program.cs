using System;

public class Car
{
    private string make;
    protected string model;

    public Car(string make_, string model_)
    {
        this.make = make_;
        this.model = model_;
    }

    public virtual void Start()
    {
        startCar();
        System.Console.WriteLine("Vehicle started");
    }

    private void startCar()
    {
        System.Console.WriteLine("Turning starter motor...");
    }

}

public class MyFirstCar : Car
{
    public MyFirstCar(string make_, string model_) : base(make_, model_)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Starting " + model);
        base.Start();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}

class MainClass
{
    public static void Main()
    {
        MyFirstCar myCar = new MyFirstCar("Toyota", "MR2");
        myCar.Start();
    }
}
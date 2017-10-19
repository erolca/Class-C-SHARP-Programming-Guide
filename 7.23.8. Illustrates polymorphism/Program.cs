using System;

public class Car
{
    public string make;
    public string model;


    // construct method
    public Car(string make, string model)
    {
        this.make = make;
        this.model = model;
    }

    public virtual void Accelerate()
    {
        Console.WriteLine(model + " accelerating");
    }

}

public class MyFirstCar : Car
{

    public MyFirstCar(string make, string model) : base(make, model)
    {
    }

    public override void Accelerate()
    {
        Console.WriteLine("Pushing gas pedal of " + model);
        base.Accelerate();
    }

}

public class MySecondCar : Car
{

    public MySecondCar(string make, string model) : base(make, model)
    {
    }

    public override void Accelerate()
    {
        Console.WriteLine("Twisting throttle of " + model);
        base.Accelerate();
    }
}


class MainClass
{
    public static void Main()
    {
        MyFirstCar myCar = new MyFirstCar("Toyota", "MR2");
        myCar.Accelerate();

        MySecondCar myMySecondCar = new MySecondCar("Harley-Davidson", "V-Rod");
        myMySecondCar.Accelerate();

    }

}
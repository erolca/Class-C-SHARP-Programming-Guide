using System;

public class Car
{
    private int maxSpeed;

    private Radio theMusicBox = new Radio();

    public Car()
    {
        maxSpeed = 100;
    }

    public void SwitchRadio(bool state)
    {
        theMusicBox.TurnOn(state);
    }
}

public class Radio
{
    public void TurnOn(bool on)
    {
        if (on)
            Console.WriteLine("ON...");
        else
            Console.WriteLine("OFF...");
    }


}

public class MainClass
{
    public static void Main(string[] args)
    {
        // Make a car.
        Car c1 = new Car();
        c1.SwitchRadio(true);
        

        c1.SwitchRadio(false);
    }
}
using System;

class Class1
{
    static void Main(string[] args)
    {
        MyCar car = new MyCar();
        int refChan = 0;
        int chan = 0;

        car.GetSpeed(chan);
        car.GetSpeed(ref refChan);
    }
}
public class MyCar
{
    private static int speed = 2;
    private const int maxSpeed = 200;

    public bool ChangeSpeed(int newSpeed)
    {
        if (newSpeed > maxSpeed)
            return false;

        speed = newSpeed;

        return true;
    }
    public void GetSpeed(int param)
    {
        param = speed;
    }

    public void GetSpeed(ref int param)
    {
        param = speed;
    }
}
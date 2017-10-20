using System;

public abstract class Clock
{
    public abstract void Play();
}

public class RedClock : Clock
{
    public override void Play()
    {
        Console.WriteLine("RedClock.Play()");
    }
}
public class BlueClock : Clock
{
    public override void Play()
    {
        Console.WriteLine("BlueClock.Play()");
    }
}
class MainClass
{
    public static void CallPlay(Clock ms)
    {
        ms.Play();
    }
    public static void Main()
    {
        Clock ms = new RedClock();
        CallPlay(ms);
        ms = new BlueClock();
        CallPlay(ms);
    }
}

//RedClock.Play()
//BlueClock.Play()
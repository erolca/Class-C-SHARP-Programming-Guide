using System;

interface IVolumeControl
{
    int Current
    {
        get;
    }
}

interface ISpeedControl
{
    int Current
    {
        get;
    }
}

public class Radio : IVolumeControl, ISpeedControl
{
    int IVolumeControl.Current
    {
        get
        {
            return 1;
        }
    }
    int ISpeedControl.Current
    {
        get
        {
            return 2;
        }
    }
}

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        ISpeedControl radioDial = (ISpeedControl)new Radio();
        Console.WriteLine("Current Speed = {0}", radioDial.Current);
    }
}
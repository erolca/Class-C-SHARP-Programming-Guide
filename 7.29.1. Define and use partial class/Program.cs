using System;

partial class XY
{
    int x;

    public int X
    {
        get { return x; }
        set { x = value; }
    }
}


partial class XY
{
    int y;

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
}


class MainClass
{
    public static void Main()
    {
        XY xy = new XY();


        Console.WriteLine(xy.X + "," + xy.Y);
    }
}
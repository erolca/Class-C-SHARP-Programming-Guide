using System;

class Point
{
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    //ctr +R +E

    //public string Name
    //{
    //    get { return name; }
    //    set
    //    {
    //        if (!value.Any(char.IsDigit))
    //        {
    //            name = "No Name";
    //        }
    //        else
    //        {
    //            name = value;
    //        }
    //    }
    //}

    // accessor functions
    public int GetX()
    {
        return (x);
    }
    public int GetY()
    {
        return (y);
    }

    // variables now private
    int x ;
    int y;
}

class MainClass
{
    public static void Main()
    {
        Point myPoint = new Point(10, 15);
        Console.WriteLine("myPoint.X {0}", myPoint.GetX());
        Console.WriteLine("myPoint.Y {0}", myPoint.GetY());
    }
}
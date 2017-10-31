using System;
using System.Collections.Generic;
using System.Text;


public class Point : ICloneable
{
    public int x, y;
    public PointDescription desc = new PointDescription();

    public Point() { }
    public Point(int x, int y)
    {
        this.x = x; this.y = y;
    }
    public Point(int x, int y, string petname)
    {
        this.x = x;
        this.y = y;
        desc.petName = petname;
    }

    public object Clone()
    {
        Point newPoint = (Point)this.MemberwiseClone();
        PointDescription currentDesc = new PointDescription();
        currentDesc.petName = this.desc.petName;
        newPoint.desc = currentDesc;
        return newPoint;
    }

    public override string ToString()
    {
        return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n", x, y, desc.petName, desc.pointID);
    }
}

public class PointDescription
{
    public string petName;
    public Guid pointID;

    public PointDescription()
    {
        this.petName = "No-name";
        pointID = Guid.NewGuid();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(50, 50);
        Point p2 = p1;
        p2.x = 0;

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        Point p3 = new Point(100, 100, "Jane");
        Point p4 = (Point)p3.Clone();

        Console.WriteLine("p3: {0}", p3);
        Console.WriteLine("p4: {0}", p4);
        p4.desc.petName = "Mr. X";
        p4.x = 9;

        Console.WriteLine("p3: {0}", p3);
        Console.WriteLine("p4: {0}", p4);
    }
}









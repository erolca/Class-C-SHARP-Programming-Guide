class Point2D
{
    public int X;
    public int Y;

    public virtual void PrintToConsole()
    {
        System.Console.WriteLine("({0}, {1})", X, Y);
    }
}

class Point3D : Point2D
{
    public int Z;

    public override void PrintToConsole()
    {
        System.Console.WriteLine("({0}, {1}, {2})", X, Y, Z);
    }
}

class MyMainClass
{
    public static void Main()
    {
        Point2D My2DPoint = new Point2D();
        Point3D My3DPoint = new Point3D();

        My2DPoint.X = 100;
        My2DPoint.Y = 200;

        My3DPoint.X = 150;
        My3DPoint.Y = 250;
        My3DPoint.Z = 350;

        My2DPoint.PrintToConsole();
        My3DPoint.PrintToConsole();
    }
}
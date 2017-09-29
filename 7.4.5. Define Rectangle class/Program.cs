using System;

class Rect
{
    public int width;
    public int height;

    public Rect(int w, int h)
    {
        width = w;
        height = h;
    }

    public int area()
    {
        return width * height;
    }
}

class UseRect
{
    public static void Main()
    {
        Rect r1 = new Rect(4, 5);
        Rect r2 = new Rect(7, 9);

        Console.WriteLine("Area of r1: " + r1.area());

        Console.WriteLine("Area of r2: " + r2.area());

    }
}
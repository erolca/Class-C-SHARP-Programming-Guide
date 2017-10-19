using System;

class Shape
{
    double pri_width;  // private 
    double pri_height; // private 

    public Shape()
    {
        width = height = 0.0;
    }

    public Shape(double w, double h)
    {
        width = w;
        height = h;
    }

    public Shape(double x)
    {
        width = height = x;
    }

    public Shape(Shape ob)
    {
        width = ob.width;
        height = ob.height;
    }

    public double width
    {
        get { return pri_width; }
        set { pri_width = value; }
    }

    public double height
    {
        get { return pri_height; }
        set { pri_height = value; }
    }

    public void showDim()
    {
        Console.WriteLine("Width and height are " +
                           width + " and " + height);
    }
}

class Triangle : Shape
{
    string style; // private 

    // A default constructor. 
    public Triangle()
    {
        style = "null";
    }

    // Constructor for Triangle. 
    public Triangle(string s, double w, double h) : base(w, h)
    {
        style = s;
    }

    // Construct an isosceles triangle. 
    public Triangle(double x) : base(x)
    {
        style = "isosceles";
    }

    // Construct an object from an object. 
    public Triangle(Triangle ob) : base(ob)
    {
        style = ob.style;
    }

    // Return area of triangle. 
    public double area()
    {
        return width * height / 2;
    }

    // Display a triangle's style. 
    public void showStyle()
    {
        Console.WriteLine("Triangle is " + style);
    }
}

class MainClass
{
    public static void Main()
    {
        Triangle t1 = new Triangle("right", 8.0, 12.0);

        // make a copy of t1 
        Triangle t2 = new Triangle(t1);

        Console.WriteLine("Info for t1: ");
        t1.showStyle();
        t1.showDim();
        Console.WriteLine("Area is " + t1.area());

        Console.WriteLine();

        Console.WriteLine("Info for t2: ");
        t2.showStyle();
        t2.showDim();
        Console.WriteLine("Area is " + t2.area());
    }
}
using System;

class Shape
{
    double pri_width;  // private 
    double pri_height; // private  

    public Shape()
    {
        width = height = 0.0;
    }

    // Constructor for Shape. 
    public Shape(double w, double h)
    {
        width = w;
        height = h;
    }

    // Construct object with equal width and height. 
    public Shape(double x)
    {
        width = height = x;
    }

    // Properties for width and height. 
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



// A derived class of Shape for triangles. 
class Triangle : Shape
{
    string style; // private 

    /* A default constructor. This automatically invokes 
       the default constructor of Shape. */
    public Triangle()
    {
        style = "null";
    }

    // Constructor that takes three arguments. 
    public Triangle(string s, double w, double h) : base(w, h)
    {
        style = s;
    }

    // Construct an isosceles triangle. 
    public Triangle(double x) : base(x)
    {
        style = "isosceles";
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
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle("right", 8.0, 12.0);
        Triangle t3 = new Triangle(4.0);

        t1 = t2;

        Console.WriteLine("Info for t1: ");
        Console.WriteLine("Area is " + t1.area());
        t1.showStyle();
        t1.showDim();
       

        Console.WriteLine();

        Console.WriteLine("Info for t2: ");
        Console.WriteLine("Area is " + t2.area());
        t2.showStyle();
        t2.showDim();
        

        Console.WriteLine();

        Console.WriteLine("Info for t3: ");
        Console.WriteLine("Area is " + t3.area());
        t3.showStyle();
        t3.showDim();
        

        Console.WriteLine();
    }
}
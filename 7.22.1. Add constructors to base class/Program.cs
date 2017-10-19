using System;

class Shape
{
    double pri_width;  // private 
    double pri_height; // private  

    public Shape(double w, double h)
    {
        Width = w;
        Height = h;
    }

    // properties for width and height. 
    public double Width
    {
        get { return pri_width; }
        set { pri_width = value; }
    }

    public double Height
    {
        get { return pri_height; }
        set { pri_height = value; }
    }

    public void showDim()
    {
        Console.WriteLine("Width and height are " +
                           Width + " and " + Height);
    }
}

class Triangle : Shape
{
    string style; // private 

    public Triangle(string s, double w, double h) : base(w, h)
    {
        style = s;
    }

    // Return area of triangle. 
    public double area()
    {
        return Width * Height / 2;
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
        Triangle t1 = new Triangle("isosceles", 4.0, 4.0);
        Triangle t2 = new Triangle("right", 8.0, 12.0);

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

//Info for t1:
//Triangle is isosceles
//Width and height are 4 and 4
//Area is 8

//Info for t2:
//Triangle is right
//Width and height are 8 and 12
//Area is 48
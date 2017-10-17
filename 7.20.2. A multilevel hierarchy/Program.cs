using System;

class Shape
{
    double pri_width;  // private 
    double pri_height; // private  

    // Default constructor. 
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
        Console.WriteLine("Width and height are " + width + " and " + height);
    }
}

class Triangle : Shape
{
    string style; // private 

    /* A default constructor. This invokes the default 
       constructor of Shape. */
    public Triangle()
    {
        style = "null";
    }

    // Constructor 
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

class ColorTriangle : Triangle
{
    string color;

    public ColorTriangle(string c, string s, double w, double h) : base(s, w, h)
    {
        color = c;
    }

    // Display the color. 
    public void showColor()
    {
        Console.WriteLine("Color is " + color);
    }

    public void showdim_()
    {
        Console.WriteLine("{0},{1}", width,height);
       
    }


}

class MainClass
{
    public static void Main()
    {
        ColorTriangle t1 = new ColorTriangle("Blue", "right", 8.0, 12.0);
        ColorTriangle t2 = new ColorTriangle("Red", "isosceles", 2.0, 2.0);

        Console.WriteLine("Info for t1: ");
        Console.WriteLine("Area is " + t1.area());
        t1.showStyle();
        t1.showDim();
        t1.showColor();
        

        Console.WriteLine();

        Console.WriteLine("Info for t2: ");
        Console.WriteLine("Area is " + t2.area());
        t2.showStyle();
        t2.showDim();
        t2.showColor();
        


     //   t1.showdim_();
    }
}


//Info for t1:
//Triangle is right
//Width and height are 8 and 12
//Color is Blue
//Area is 48

//Info for t2:
//Triangle is isosceles
//Width and height are 2 and 2
//Color is Red
//Area is 2
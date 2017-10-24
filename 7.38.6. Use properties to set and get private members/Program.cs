using System;

class Shape
{
    double pri_width;  // now private 
    double pri_height; // now private  

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

class Triangle : Shape
{
    public string style; // style of triangle 

    public double area()
    {
        return width * height / 2;
    }

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
        Triangle t2 = new Triangle();

        t1.width = 4.0;
        t1.height = 4.0;
        t1.style = "isosceles";

        t2.width = 8.0;
        t2.height = 12.0;
        t2.style = "right";

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
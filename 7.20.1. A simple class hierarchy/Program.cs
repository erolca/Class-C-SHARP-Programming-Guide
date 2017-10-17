using System;

// 1-A class that is inherited is called a base class.
// 2-The inheriting class is called a derived class.
// 3-A derived class is a specialized version of a base class.
// 4-A derived class has all of the variables, methods, properties, operators, and indexers from the base class
// 5-A derived class adds its own unique elements.
// 6-The general form of a class declaration that inherits a base class:

//class derived-class-name : base-class-name {
//    // body of class
//}

class Shape 
{
    public double width;
    public double height;

    public void showDim()
    {
        Console.WriteLine("Width and height are " +
                           width + " and " + height);
    }
}

class Triangle : Shape
{
    public string style; // style of triangle 

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
using System;

class Rect
{

    // feilds....
    int width;
    int height;


    // constructor
    public Rect(int w, int h)
    {
        width = w;
        height = h;
    }


    //methods
    public int area()
    {
        return width * height;
    }


    //methods
    public void show()
    {
        Console.WriteLine(width + " " + height);
    }


    //methods
    public Rect enlarge(int factor)
    {
        return new Rect(width * factor, height * factor);
    }
}

class MainClass
{
    public static void Main()
    {
        Rect r1 = new Rect(4, 5);

        Console.Write("Dimensions of r1: ");
        r1.show();
        Console.WriteLine("Area of r1: " + r1.area());

        Console.WriteLine();

        // create a rectangle that is twice as big as r1 
        Rect r2 = r1.enlarge(2);

        Console.Write("Dimensions of r2: ");
        r2.show();
        Console.WriteLine("Area of r2 " + r2.area());
    }
}


//Dimensions of r1: 4 5
//Area of r1: 20

//Dimensions of r2: 8 10
//Area of r2 80
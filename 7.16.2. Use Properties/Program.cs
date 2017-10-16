using System;


//	7.16.2.	Use Properties to get and set private member variable
class Circle
{
    int radius;

    public int Radius
    {
        get
        {
            return (radius);
        }
        set
        {
            radius = value;
        }
    }

}
class MainClass
{
    public static void Main()
    {
        Circle c = new Circle();
        c.Radius = 35;
    }
}
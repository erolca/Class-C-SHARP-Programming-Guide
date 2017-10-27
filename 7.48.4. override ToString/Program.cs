using System;
using System.Collections;

struct RGB
{
    private int red;
    private int green;
    private int blue;


    // Propeties geri donus turu RGB class
    public static RGB Red
    {
        get
        {
            return (new RGB(255, 0, 0));
        }
    }
    public static RGB Green
    {
        get
        {
            return (new RGB(0, 255, 0));
        }
    }
    public static RGB Blue
    {
        get
        {
            return (new RGB(0, 0, 255));
        }
    }

   // public int Red1 { get => red; set => red = value; }

    public RGB(int red_, int green_, int blue_)
    {
        this.red = red_;
        this.green = green_;
        this.blue = blue_;
    }

   


    public override String ToString()
    {
        return red.ToString("X")
            + green.ToString("X")
            + blue.ToString("X");
    }
}

class BoxTest
{
    static ArrayList rgbValues;

    public static void Main()
    {
        RGB rgb = new RGB(255, 255, 255);

        RGB red = RGB.Red;

        rgbValues = new ArrayList();
        rgbValues.Add(rgb);
        rgbValues.Add(red);

        Console.WriteLine("The RGB value is {0}", rgb);
        Console.WriteLine("The RGB value is {0}", red);
    }
}
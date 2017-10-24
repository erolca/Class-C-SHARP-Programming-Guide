using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Color
{
    public Color(int red_, int green_, int blue_)
    {
        this.red = red_;
        this.green = green_;
        this.blue = blue_;
    }

    int red;
    int green;
    int blue;

    public static readonly Color Red;
    public static readonly Color Green;
    public static readonly Color Blue;

    static Color()
    {
        Red = new Color(255, 0, 0);
        Green = new Color(0, 255, 0);
        Blue = new Color(0, 0, 255);
    }
}

class MainClass
{
    static void Main()
    {
        Color background= Color.Red;
    }
}
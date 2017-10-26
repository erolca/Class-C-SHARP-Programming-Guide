using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public static Color Red
    {
        get
        {
            return (new Color(255, 0, 0));
        }
    }
    public static Color Green
    {
        get
        {
            return (new Color(0, 255, 0));
        }
    }
    public static Color Blue
    {
        get
        {
            return (new Color(0, 0, 255));
        }
    }
}
class MainClass
{
    static void Main()
    {
        Color background = Color.Red;
        Color forecolor = new Color(0, 255, 0);
    }
}
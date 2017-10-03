using System;

class Color
{
    public Color()
    {
        this.red = 0;
        this.green = 127;
        this.blue = 255;
    }

    protected int red;
    protected int green;
    protected int blue;

    public void GetRGB(ref int red, ref int green, ref int blue)
    {
        red = this.red;
        green = this.green;
        blue = this.blue;
    }

}

class Class1
{
    static void Main(string[] args)
    {
        Color c = new Color();
        int red = 1;
        int green = 2;
        int blue = 3;
        c.GetRGB(ref red, ref green, ref blue);

        Console.WriteLine("R={0}, G={1}, B={2}", red, green, blue);
    }
}
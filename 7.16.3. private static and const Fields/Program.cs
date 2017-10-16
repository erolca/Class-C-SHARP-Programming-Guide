using System;

class MainClass
{
    static void Main(string[] args)
    {
        MyTV tv = new MyTV();
    }
}
public class MyTV
{
    public MyTV()
    {
        channel = 2;
    }
    private static int channel = 2;
    private const int maxChannels = 200;
}
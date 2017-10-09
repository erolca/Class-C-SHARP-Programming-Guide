﻿using System;
class MyObject
{
    public MyObject(int x)
    {
        this.x = x;
    }
    // constructor
    public MyObject(int x, int y) : this(x)
    {
        this.y = y;
    }
    public int X
    {
        get
        {
            return (x);
        }
    }
    public int Y
    {
        get
        {
            return (y);
        }
    }
    int x;
    int y;
}
class MainClass
{
    public static void Main()
    {
        MyObject my = new MyObject(10, 20);
        Console.WriteLine("x = {0}, y = {1}", my.X, my.Y);
    }
}
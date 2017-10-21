using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Component
{
    public Component() { }
}

interface IPrintable
{
    void printHeader(float factor);
    void printFooter(float factor);
}

public class TextField : Component, IPrintable
{
    public TextField(string text)
    {
        this.text = text;
    }
    // implementing Printable.printHeader()
    public void printHeader(float factor)
    {

    }

    // implementing Printable.printFooter()
    public void printFooter(float factor)
    {

    }

    private string text;
}

class MainClass
{
    public static void Main()
    {
        TextField text = new TextField("Hello");

        IPrintable scalable = (IPrintable)text;
        scalable.printHeader(0.5F);
        scalable.printFooter(0.5F);
    }
}
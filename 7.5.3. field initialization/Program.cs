using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FieldInitExample
{

    // field..
    int x = 5;
    int y;

    public FieldInitExample() : this(5)
    {
    }


    //this(5)
    public FieldInitExample(int y)
    {
        this.y = y;
    }
}

namespace field_initialization
{
    class Program
    {
        static void Main(string[] args)
        {

            FieldInitExample d = new FieldInitExample();

        }
    }
}

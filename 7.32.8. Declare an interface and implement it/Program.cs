using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IMyIF
{
    int myMeth(int x);
}

class MyClass : IMyIF
{
    int IMyIF.myMeth(int x)
    {
        return x / 3;
    }
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }


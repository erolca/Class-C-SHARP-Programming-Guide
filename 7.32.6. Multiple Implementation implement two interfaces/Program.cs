using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


interface IFoo
{
    void ExecuteFoo();
}

interface IBar
{
    void ExecuteBar();
}

class Tester : IFoo, IBar
{
    public void ExecuteFoo() { }
    public void ExecuteBar() { }
}



class Program
    {
        static void Main(string[] args)
        {
        }
    }


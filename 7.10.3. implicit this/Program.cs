using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass
{
    int state;
    public void Foo()
    {
        state++;
        this.state++;
    }

    static void Main(string[] args)
    {
        MainClass d = new MainClass();
        d.Foo();
    }

}

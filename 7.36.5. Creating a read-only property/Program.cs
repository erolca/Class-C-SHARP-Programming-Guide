using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

public class ClassWithReadOnlyProperty
{
    int fAge;

    public int Age
    {
        get
        {
            return fAge;
        }
    }
    public ClassWithReadOnlyProperty()
    {
        fAge = 21;
    }
}

class MainClass
{
    static public void Main()
    {
        ClassWithReadOnlyProperty crp = new ClassWithReadOnlyProperty();
        Console.WriteLine("Age {0}", crp.Age);

    }
}
using System;


//7.32.13.	Abstract Interface: how the abstract BaseClass can interface.

public interface ICompare
{
    int GetValue();
    int Compare(ICompare ic);
}

abstract public class BaseClass : ICompare
{
    int nValue;

    public BaseClass(int nInitialValue)
    {
        nValue = nInitialValue;
    }

    public int Value
    {
        get { return GetValue(); }
    }
    public int GetValue()
    {
        return nValue;
    }

    abstract public int Compare(ICompare bc);
}

public class SubClass : BaseClass
{
    public SubClass(int nInitialValue): base(nInitialValue)
    {
    }

    override public int Compare(ICompare ic)
    {
        return GetValue().CompareTo(ic.GetValue());
    }
}

public class Class1
{

    public static void Main(string[] strings)
    {
        SubClass sc1 = new SubClass(10);
        SubClass sc2 = new SubClass(20);

        MyFunc(sc1, sc2);
    }

    public static void MyFunc(ICompare ic1, ICompare ic2)
    {
        Console.WriteLine("bc1.Compare(bc2) returned {0}",ic1.Compare(ic2));
    }
}
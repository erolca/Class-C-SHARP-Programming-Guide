using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
The general form of a class that implements an interface is shown here:

class class-name : interface-name {
// class-body
}

To implement more than one interface, the interfaces are separated with a comma.
A class can inherit a base class and also implement one or more interfaces.
The name of the base class must come first in the comma-separated list.
The methods that implement an interface must be declared public.

 */
public interface ISeries
{
    int getNext();
    void setStart(int x);
}


class Sequence : ISeries
{
    int val;

    public void ByTwos()
    {
    }

    public int getNext()
    {
        return val++;
    }

    public void setStart(int x)
    {
        val = x;
    }
}


class Program
    {
        static void Main(string[] args)
        {
        }
    }


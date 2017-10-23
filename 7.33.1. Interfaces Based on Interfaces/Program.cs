using System;
using System.Runtime.Serialization;
/*
 
1-One interface can inherit another.
2-The syntax is the same as for inheriting classes.

*/

interface IComparableSerializable : IComparable, ISerializable
{
    string GetStatusString();
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }


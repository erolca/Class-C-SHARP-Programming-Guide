using System;
using System.ComponentModel;

partial class Example<TFirst, TSecond> : IEquatable<string> where TFirst : class
{
    public bool Equals(string other)
    {
        return false;
    }
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }


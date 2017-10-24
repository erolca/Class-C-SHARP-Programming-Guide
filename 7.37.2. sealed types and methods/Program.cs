using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//To prevent a class from being inherited, precede its declaration with sealed.
sealed class FooSealed { }

class BaseClass
{
    protected virtual void Bar() { /*...*/ }
}

class Derived : BaseClass
{
    protected override sealed void Bar() { /* ... */ }
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }

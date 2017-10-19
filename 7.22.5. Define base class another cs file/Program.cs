using System;
using BaseClassNS;

namespace UsesBaseClass
{
    class DerivedClass : MyBaseClass
    {
    }

    class MainClass
    {
        static void Main()
        {
            DerivedClass mdc = new DerivedClass();
            mdc.PrintMe();
        }
    }
}
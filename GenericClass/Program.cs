using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
   



    class MyClass<T> where T : A
    {
        T t;
        A a;

        public void X()
        {

          

        }
    }

    class A
    {

    }
    class B:A
    {

    }
    class C:B
    {

    }
    class D
    {

    }

    #region Generic New Constraint

    class MyClass_Examp<T> where T: MyClass2, new()
    {
        T t;
        A a;

        public void X()
        {

            t = new T();

        }


    }
    class MyClass2
    {

    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {

            // MyClass<Ornek,Ornek2> m1 = new MyClass<Ornek, Ornek2>();
            //  MyClass<A> m1 = new MyClass<A>();
            //MyClass<B> m1 = new MyClass<B>();
            MyClass<C> m1 = new MyClass<C>();
            //MyClass<D> m1 = new MyClass<D>();
        }
    }
}

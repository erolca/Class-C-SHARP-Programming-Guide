using System;
using System.ComponentModel;

class Outer<T>
{
    public class Inner<U, V>
    {
        static Inner()
        {
            Console.WriteLine("Outer<{0}>.Inner<{1},{2}>",
                              typeof(T).Name,
                              typeof(U).Name,
                              typeof(V).Name);
        }
        public static void DummyMethod()
        {
        }
    }

}

class Mainclass
{
    static void Main()
    {
         Outer<int>.Inner<string, DateTime>.DummyMethod();
        
    }
}
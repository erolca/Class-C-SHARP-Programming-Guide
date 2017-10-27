using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Sealed sınıflar kalıtım vermeyen sınıflardır.
 * Bir sınıfın başka sınıflara kalıtım vermesini engellemek için sealed komutu kullanılır.
 * Sealed classları bir çeşit güvenlik önlemi olarak düşünebiliriz. Yanlışlıkla türetilmeleri engellenmiş oluyor.
 */
 public class BaseClass
    {
    
    
    
    }
sealed class MyClass//: BaseClass
{
    MyClass() { }
}

class Program
    {
        static void Main(string[] args)
        {
        //error CS0122: 'MyClass.MyClass()' is inaccessible due to its protection level
      //  MyClass d = new MyClass();

        }
    }


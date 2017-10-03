using System;
/*
 Fonksiyonlar tekrarlama yapılarına göre temel olarak iki türlü düşünülebilir. 
   Buna göre bir fonksiyonun içinde yine kendisinden bir parça bulunuyorsa 
   bu fonksiyonlara özyineli (recursive) fonksiyon denilirken, fonksiyonun 
   kendisini tekrar etmemesi durumunda döngülü (iterative) fonksiyon ismi verilir.
   Teorik olarak bütün döngülü (iterative) fonksiyonlar özyineli (recursive) fonksiyon olarak yazılabilir (tersi de doğrudur).
  */
class Factorial
{
       
    // This is a recursive function.  
    public int factR(int n)
    {
        int result;

        if (n == 1)
                return 1;
        return ( factR(n - 1) * n); //A method can call itself is called recursion.
        //return result;
    }

    // This is an iterative equivalent.  
    public int factI(int n)
    {
        int t, result;

        result = 1;
        for (t = 1; t <= n; t++)
            result *= t;
        return result;
    }


    public void facr(int n)
    {
        if (n == 0)
            return;
        facr(n - 1);
        Console.WriteLine("Deger : {0}", n);

        //return;
    }




}

class MainClass
{
    public static void Main()
    {
        Factorial f = new Factorial();
       
        Console.WriteLine("Factorials using recursive method.");
        Console.WriteLine("Factorial of 3 is " + f.factR(3));
        Console.WriteLine("Factorial of 4 is " + f.factR(4));
        Console.WriteLine("Factorial of 5 is " + f.factR(5));
        Console.WriteLine();

        Console.WriteLine("Factorials using iterative method.");
        Console.WriteLine("Factorial of 3 is " + f.factI(3));
        Console.WriteLine("Factorial of 4 is " + f.factI(4));
        Console.WriteLine("Factorial of 5 is " + f.factI(5));


        /**/
             f.facr(5);

       
    }
}
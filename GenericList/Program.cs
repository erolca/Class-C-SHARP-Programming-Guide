using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Sayilar = new int[25];
            //Eleman sayısını önceden belirtmemiz gerekiyor
            //Elemenları atamasak dahi bellekte yerleri  ayrılıyorlar.
            //Performans acısından zayıflar
            //Eleman atarken yahut okurken kod maliyeti..
            // vs. vs..

            #region ArrayLıst
            //ArrayList liste = new ArrayList(); // using System.Collections; eklenmeli

                                               //// koleksiyonlarda indexer kullanılmaz...
                                               //// koleksiyonlar sınıflardır...
                                               ////içine object alır Boxing unboxing  arka planda olmaktadır

            //liste.Add("Merhaba");
            //liste.Add("Error");
            //liste.Add(123);
            //liste.Add(true);

            //Console.WriteLine("{0}", liste[0]);
            //Console.WriteLine("{0}", liste[1]);
            //Console.WriteLine("{0}", liste[2]);


            //foreach (var item in liste)
            //{
            //    if (item is int)
            //    {

            //        Console.WriteLine((int) item +120);
            //    }

            //}

            #endregion

            #region List

            List<int> liste = new List<int>();// bu bir sınıftır
             //List<int> : Bu koleksiyon yapısına int tipinden başka değer eklenemez.
            liste.Add(12);
            liste.Add(10);
            liste.Add(17);
            liste.Add(21);
            #endregion

            foreach (var item in liste)
            {
                Console.WriteLine("{0}", item);
            }
            Console.Read();

        }
    }
}

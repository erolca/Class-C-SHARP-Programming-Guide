using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Tip
{
    class Ogrenci
    {
        public string isim;
        public double notOrtalamasi;
        public string bolum;
        public Ogrenci(string isim, double notOrtalamasi, string bolum)
        {
            this.isim = isim;
            this.notOrtalamasi = notOrtalamasi;
            this.bolum = bolum;
        }

       override public string ToString()
        {

            return " İsim: " + isim + " Bölüm : " + bolum + " notOrtalaması :" + notOrtalamasi;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ali = new Ogrenci("Ali Demir",90,"Bilgisayar");
            List<Ogrenci> sinif = new List<Ogrenci>();
            sinif.Add(ali);

            Console.WriteLine("dogrudan obje : " + ali);
            Console.WriteLine("listeden ilk eleman: " + sinif.ElementAt(0));
            Console.WriteLine("listeden ilk eleman: " + sinif[0]);
            Console.WriteLine(sinif.Capacity);
            sinif.Add(new Ogrenci("Veli Yıldız", 80, "Coğrafya"));
            sinif.Add(new Ogrenci("Ahmet Çakır", 40, "Metamatik"));
            sinif.Add(new Ogrenci("Cem Baki", 70, "Bilgisayar"));
            sinif.Add(new Ogrenci("Ayşe Demir", 65, "Coğrafya"));
            sinif.Add(new Ogrenci("Fatma Demir", 25, "Coğrafya"));
            

            foreach (var item in sinif)
            {
                Console.WriteLine( item);
            }
            Console.WriteLine(sinif.Count);
            Console.WriteLine(sinif.Capacity);
            var sonuc =
                from x in sinif
                where x.notOrtalamasi >= 80
                orderby x.isim
                select x;
            foreach (Ogrenci x in sonuc)
            {
                Console.WriteLine(x);
            }



        }
    }
}

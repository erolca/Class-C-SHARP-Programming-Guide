using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 Değer (Value types) tiplerinde birbirine “=” ile atama işlemi yaptığımızda bit bit kopyalanarak atama işlemi gerçekleştirilir. 
 Birbirinden bağımsız iki farklı instance vardır artık.
 Referans tiplerde atama yapıldığında ise atanan tip değişkenine atanılan tipin heap bellekte gösterdiği alanın adresi atanmaktadır.
 Her iki değişkende aynı veri kümesini işaret eder. 
 Bir değişkenle yaptığınız değişiklik diğer değişken için de geçerli olur çünkü iki değişkende bellekte aynı veri kümesine işaret ediyorlar.
 Değer tipler de söylediğimiz gibi atanan değişken atanılan değişkenden bağımsızdır.

Peki referans tiplerin değer tiplerde olduğu gibi atama işlemini gerçekleştirirken kopyalanmasını istersek ne yapmalıyız.
Bazı durumlarda referans türü nesnelerimizin program akışı içinde o andaki halini tekrar daha sonra kullanacağımız durumlar olabilir. 
Bazen yapmamız gerekir. .Net bu gibi durumlar için bize Object tipinde geri değer dönderen  Object MemberwiseClone() metodunu sunmakta.
MSDN den açıklamasında baktığımız zaman ‘Creates a shallow copy of the current Object.’ yazar. Shallow copy Sığ kopyalama olarak tercüme edebiliriz. Mevcut Objenin sığ kopyasını oluşturur. Araştırıldığı zaman Shallow copy ve Deep copy diye kopyalama işlemi için bu iki terimin kullanıldığını görüyoruz.

Shallow copy: nesnenin üye elemanlarını kopyalar. Eğer bu üye eleman Değer tipinde ise bit bit kopyalama işlemi gerçekleştirilir.
Eğer üye eleman referans tipinde ise referans kopyalanır fakat referansın gösterdiği veri kümesi kopyalanmaz.
Orjinal nesne ve Kopyalanmış nesnede yer alan referans tipi üye eleman bellekte aynı veri kümesine işaret eder.
Kopyalama işlemi static üye elemanları için geçersizdir.

Deep copy: nesnenin bütün değer ve referans üye elemanlarını bit bit kopyalama işlemine denir.
Deep copy işlemini kendimiz yazmamız gerekmektedir. Deep copy için .Net in sunduğu herhangi bir sınıf metod bulunmamaktadır.
Fakat MemberwiseClone() metodunu da kullanarak geliştireceğimiz bir metot ile deep copy işlemini gerçekleştirebiliriz. Örneğimize geçelim.
  */

class KimlikBilgisi 
{
    public int KimlikID;
    public int kimlikseri;
    public KimlikBilgisi(int KimlikID)
    {
        this.KimlikID = KimlikID;
    }

}



class Vatandaş 
{
    public String Ad;
    public String Soyad;
    public int Yaş;

    public KimlikBilgisi KimlikBilgisi;

    public Vatandaş ShallowCopy()
    {
        return (Vatandaş)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return "Adı: " + Ad + " Soyadı: " + Soyad + " Yaşı: " + Yaş + " KimlikID: " + KimlikBilgisi.KimlikID.ToString();
    }
}
class MyClass
{


    static void Main(string[] args)
    {
        Vatandaş v1 = new Vatandaş();
        v1.Ad = "Fatih";
        v1.Soyad = "Sarıyıldız";
        v1.Yaş = 27;
        v1.KimlikBilgisi = new KimlikBilgisi(5555);


        Vatandaş v2 = v1.ShallowCopy();
        v2.Ad = "Oğuz";
        v2.Soyad = "Yalçın";
        v2.Yaş = 18;
        v2.KimlikBilgisi.KimlikID = 1111;
        v2.KimlikBilgisi.kimlikseri = 983748928;

        Console.WriteLine("{    v1 Bilgisi    }");
        Console.WriteLine(v1);
        Console.WriteLine("{    v2 Bilgisi    }");
        Console.WriteLine(v2);
        Console.ReadLine();
    }

}
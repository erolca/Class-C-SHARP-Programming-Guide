using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KimlikBilgisi
{
    public int KimlikID;
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

    public Vatandaş DeepCopy()
    {
        Vatandaş deep = (Vatandaş)this.MemberwiseClone();
        deep.KimlikBilgisi = new KimlikBilgisi(this.KimlikBilgisi.KimlikID);
        return deep;
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

        Vatandaş v2 = v1.DeepCopy();
        v2.Ad = "Oğuz";
        v2.Soyad = "Yalçın";
        v2.Yaş = 18;
        v2.KimlikBilgisi.KimlikID = 1111;

        Console.WriteLine("{    v1 Bilgisi    }");
        Console.WriteLine(v1);
        Console.WriteLine("{    v2 Bilgisi    }");
        Console.WriteLine(v2);
        Console.ReadLine();
    }
}
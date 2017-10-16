using System;


/*
 * Bilindiği üzere referans tipleri belleğin heap bölgesinde tutulmaktadır.
 * Bu durumun sonucu olarak iki referans tipi arasında bir atama işlemi söz konusu olduğunda,
 * aslında bu referans tiplerinin heap bellek bölgesinde yer alan adresleri eşitlenmektedir. 
 * Böyle olunca da referans tiplerinin her hangi birisinde yapılan değişiklik diğerini de otomatikman etkileyecektir.
 * Bu referans tiplerinin değer tiplerinden farklı olduğu bi yönüdür. Çünkü değer tiplerinde bir eşitleme söz konusu olduğunda
 * nesnenin yenisi yaratılmaktadır.
 * 
    Araba araba = new Araba();
    Araba _araba = araba;
    _araba referansına = operatörü ile araba referansı atanırsa,
    bu referanslara bağlı olan nesnelerin BELLEK ÜZERİNDEKİ ADRESLERİ kopyalanmaktadır. 
    Yani aşağıdaki şemada olduğu gibi iki referansta aynı nesneyi göstermektedir.
*
* Referans tiplerinde de biz değer tiplerinde olduğu gibi eşitleme yaptığımızda
* bu referansların birbirlerini etkilememelerini isteyebiliriz.
* Bu durumda IClonable arayüzünü uygulayarak referans tipinin klonlanmasını sağlayabiliriz. 
* Bunun nasıl yapıldığına geçmeden önce iki referans tipinin birbirine eşitlenmesi sonucu nasıl adreslerinin eşitlendiğine bir örnek verelim.
*/
public sealed class Dimensions : ICloneable
{
    public Dimensions(long width, long height)
    {
        this.width = width;
        this.height = height;
    }

    private Dimensions(Dimensions other)
    {
        this.width = other.width;
        this.height = other.height;
    }

    public  object Clone()
    {
        return new Dimensions(this);
    }

    public string Print()
    {
        return string.Format("{0},{1}",this.width,this.height);

    }

    public override string ToString()
    {
        return string.Format("Class fields: " + this.width + " " + this.height);
    }

    private long width;
    private long height;
}





class MainClass
{


   static void Main()
    {
        Dimensions t1 = new Dimensions(100,50);
        Dimensions t2 = new Dimensions(10, 20);
        Console.WriteLine("t2 value : {0}", t2.Print());
      
        t2 = (Dimensions)t1.Clone();
        Console.WriteLine("t2 value : {0}", t1.Print());
        Console.WriteLine("t2 value : {0}", t2.Print());

        Console.WriteLine(t2);


        
        if (t1.Equals(t2))
            Console.WriteLine("Objects are the same...");
        else
            Console.WriteLine("Objects are different...");



        Console.ReadLine();

        ///
        Student einstein = new Student("Albert", "Einstein", 80);
        Student thomas = (Student)einstein.Clone();
        Console.WriteLine(einstein);
        thomas.Name = "Thomas";
        Console.WriteLine(einstein);

        Console.ReadLine();


    }

}
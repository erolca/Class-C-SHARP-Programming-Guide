using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.16.1.	Define private constructors to make a singleton

/*
 LOCK
 Eğer birden fazla Thread üzerinde işlem
 gerçekleştiriyorsanız ve bu işlemler kümesinde belirli kod
 alanlarında tek Thread olarak işlev yapacaksanız Lock keywordünü kullanabilirsiniz.
 Anlayacağınız elinizde çoklu Thread akışındaki bir işlev kesitini tek kanala
 indirgeyerek aslında o işlem bitmeden başka kanallarda Process sürecini durdurmanızı
 garanti altına alacaktır. Haliyle kodunuzun sadece o anda çalıştırmak istediğiniz yer
 dışında Thread’lar beklemeye alınacaktır.

 http://www.gencayyildiz.com/blog/cta-lock-anahtar-sozcugu/

Remarks
The lock keyword ensures that one thread does not enter
a critical section of code while another thread is in the critical section. 
If another thread tries to enter a locked code, 
it will wait, block, until the object is released.
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement
 */

public class MyClass
{
    static MyClass cache = null;
    static object cacheLock = new object();


    public static int currentCount;
    public static int IncrementCount()
    {
        return ++currentCount;
    }

    private MyClass()
    {
        // useful stuff here
    }

    public static MyClass GetMyClass()
    {

        /*
         * LOCK ile
         Gördüğünüz gibi MyClass’da lock keywordü ile nesne kontrol ve üretim
         sürecinde başka Thread’ların çalışmasını durduruyoruz. 
         Çalışma mantığımızı garanti altına alıyoruz.
         
         */
        lock (cacheLock) // lock için acıklama yukarıda
        {
            if (cache == null)
                cache = new MyClass();

            return (cache);
        }
    }
}

public class Sample
{
    int x, y, z;
    string name;
    bool flag;

    private Sample()
    {
        x = 5;
        y = 10;
        z = 15;
        flag = true;
    }

    public Sample(string Name): this()
    {
        //flag, x, y, and z are initialized here
        name = Name;
    }

    public Sample(string Name, bool flag): this(Name)   //Constructor chaining
    {
        //name, flag, x, y, and z are initialized here, but we need to change flag
        this.flag = flag;
    }
}


class Program
    {
        static void Main(string[] args)
        {

        MyClass.currentCount = 100;
        MyClass.IncrementCount();
        Console.WriteLine("New count: {0}", MyClass.currentCount);
        
        MyClass t1= MyClass.GetMyClass();


       

        // new example sample
        Sample s1 = new Sample("BlahBlah");
        Sample s2 = new Sample("BlahBlooBlee", false);

    }
    }


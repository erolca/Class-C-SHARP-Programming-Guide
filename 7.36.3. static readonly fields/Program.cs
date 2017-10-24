using System;
/*
 * const : Türkçe’ye Sabit olarak çevrilebilir. Class seviyesinde tanımlanır ve tanımlanma anında değeri verilmek zorundadır.
 * Sonradan değeri değiştirilemez.
 * 
 * readonly : Sadece-Okunabilir anlamına gelir. Class seviyesinde tanımlanır. 
 * Tanımlandığı anda değeri verilebilir veya Class Constructor’ında değeri verilebilir.
 * Sonradan değeri değiştirilemez.
*/

public class Bicycle
{

    public readonly string make;

    public static readonly int wheels = 4;

    public Bicycle(string make_)
    {
       Console.WriteLine("Creating a Bicycle object");
        this.make = make_;
    }
}


class MainClass
{

    public static void Main()
    {
       Console.WriteLine("Bicycle.wheels = " + Bicycle.wheels);

        Bicycle myBicycle = new Bicycle("AAA");

        Console.WriteLine("myBicycle.make = " + myBicycle.make);

    }

}
using System;

class MyValue
{
    public MyValue(int count)
    {
        this.count = count;
    }
    public int count;
}
class MyObject
{
    public String Name;
    public int ID;

    public MyObject(String Name, int ID, int count)
    {

        this.Name = Name;
        this.ID = ID;
        this.contained = new MyValue(count);



    }
    public MyObject Clone()
    {
        Console.WriteLine("Clone");
        return ((MyObject)MemberwiseClone()); // burada klonlama işlemi yapılırken Referans tipli değişkenlerin Referensı kopyalanmaktadır.
    }
    public MyValue contained;
}
class MainClass
{
    public static void Main()
    {
        MyObject my = new MyObject("John",1001,3);
        MyObject myClone = my.Clone();
        Console.WriteLine("Values: {0} {1}", my.contained.count, myClone.contained.count);
        Console.WriteLine("Name: {0} {1}", my.Name, myClone.Name);
        myClone.contained.count = 1;
        myClone.Name = "Robin";
        Console.WriteLine("Values: {0} {1}", my.contained.count, myClone.contained.count);
        Console.WriteLine("Name: {0} {1}", my.Name, myClone.Name);
        //deger atamalı olan degiskenler degişmektedir..
    }
}

//Clone
//Values: 3 3
//Values: 1 1
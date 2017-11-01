using System;

class MyValue
{
    public MyValue(int count)
    {
        this.count = count;
    }
    public int count;
}


class MyObject : ICloneable
{
    public MyValue contained;
    public int ID=77;

    public MyObject( int count)
    {
        this.contained = new MyValue(count);
    }


    public object Clone()
    {
        Console.WriteLine("Clone");
        return (new MyObject(this.contained.count));
    }

    // benim yazdığım....
    public object Memberwise_Clone()
    {
        Console.WriteLine("Memberwise_Clone");
        return MemberwiseClone();
    }
   
}
class MainClass
{
    public static void Main()
    {
        MyObject my = new MyObject(33);
        my.ID = 17;
        MyObject myClone = (MyObject)my.Clone();
      


        
        Console.WriteLine("Values: {0} {1}", my.contained.count, myClone.contained.count);
        myClone.contained.count = 15;
        Console.WriteLine("Values: {0} {1}", my.contained.count, myClone.contained.count);

        
        MyObject em = new MyObject(1131);
        em.ID = 18;
        MyObject cloneEmployee = (MyObject)em.Memberwise_Clone();//Shallow copy Sığ kopyalama

        Console.WriteLine("Values: {0} {1}", em.contained.count, cloneEmployee.contained.count);
        em.contained.count = 56;
        Console.WriteLine("Values: {0} {1}", em.contained.count, cloneEmployee.contained.count);

    }
}
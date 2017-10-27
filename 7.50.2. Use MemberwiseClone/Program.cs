using System;

//7.50.2.	Use MemberwiseClone method to clone object
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
    public MyValue contained;

    public MyObject(int count)
    {
        this.contained = new MyValue(count);
    }
    public MyObject Clone()
    {
        Console.WriteLine("Clone");
        return ((MyObject)MemberwiseClone());
    }
    
}
class MainClass
{
    public static void Main()
    {
        MyObject my = new MyObject(3);
        MyObject myClone = my.Clone();
        Console.WriteLine("Values: {0} {1}", my.contained.count, myClone.contained.count);
        myClone.contained.count = 1;
        Console.WriteLine("Values: {0} {1}", my.contained.count, myClone.contained.count);
    }
}
//Clone
//Values: 3 3
//Values: 1 1
using System;
using System.Reflection;
using System.Globalization;
class Class1
{


    DateTime[] dateTimes = new DateTime[10];

    public DateTime this[int index]
    {
        get { return dateTimes[index]; }
        set { dateTimes[index] = value; }
    }


    private DateTime dateOfBirth;
    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public void Test()
    {
        Console.WriteLine("Test method called");
    }


    private string field;

    public string Property
    {
        get { return field; }
        set { field = value; }
    }

}


class MainClass
{

    static void Main(string[] args)
    {
        Type type = typeof(Class1);
        Console.WriteLine(type.FullName);

        object o = Activator.CreateInstance(type);
        type.InvokeMember("Item", BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.Public,
          null, o, new object[] { 0, new DateTime(1966, 2, 12) });

        Console.WriteLine(((Class1)o)[0].ToString());


      
      /*  Type typeArray = typeof(int);
        object d = Activator.CreateInstance(typeArray);*/
       
      


    }
}
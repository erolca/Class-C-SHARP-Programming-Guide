using System;

class MainClass
{
    private int fValue;
    public MainClass()
    {
        fValue = 0;
    }
    public void setValue(int value)
    {
        fValue = value;
    }
    public int getValue()
    {
        return fValue;
    }

    public static void Main()
    {
      

        MainClass[] arr = new MainClass[10];
        for (int i = 0; i < 10; ++i)
            arr[i] = new MainClass();

        for (int i = 0; i < 10; ++i)
            arr[i].setValue(i);

        for (int i = 0; i < 10; ++i)
            Console.WriteLine("Object {0}. Value = {1}",
              i, arr[i].getValue());

        //veya
        foreach (MainClass item in arr)
        {
            Console.WriteLine("Object. Value = {1}", item.getValue());
        
        }

    }
}
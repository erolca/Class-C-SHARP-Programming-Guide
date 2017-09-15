using System;

interface Getter
{
    int GetData();
}


interface Setter
{
    void SetData(int x);
}


    

class MyData : Getter, Setter
{
    int data;
    public int GetData()
    {
        return data;
    }
    public void SetData(int x)
    {
        data = x;
    }
}

class MainClass
{
    static void Main()
    {
        MyData data = new MyData();

        data.SetData(5);
        Console.WriteLine("Value = {0}", data.GetData());
    }
}
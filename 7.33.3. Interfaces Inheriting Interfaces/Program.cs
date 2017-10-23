using System;

interface Getter
{
    int GetData();
}

interface Setter
{
    void SetData(int x);
}

interface GetterAndSetter : Getter, Setter
{
}

class MyData : GetterAndSetter
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
        Console.WriteLine("{0}", data.GetData());
    }
}
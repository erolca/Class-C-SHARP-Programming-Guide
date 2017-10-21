using System;

public interface ISeries
{
    int getNext();
    void setStart(int x);
}


class Sequence : ISeries
{
    int val;

    public Sequence()
    {
    }

    public int getNext()
    {
        return val++;
    }

    public void setStart(int x)
    {
        val = x;
    }
}


class MainClass
{
    public static void Main()
    {
        Sequence ob = new Sequence();

        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " + ob.getNext());


        Console.WriteLine("\nStarting at 100");
        ob.setStart(100);
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " + ob.getNext());
    }
}

//Next value is 0
//Next value is 1
//Next value is 2
//Next value is 3
//Next value is 4

//Starting at 100
//Next value is 100
//Next value is 101
//Next value is 102
//Next value is 103
//Next value is 104
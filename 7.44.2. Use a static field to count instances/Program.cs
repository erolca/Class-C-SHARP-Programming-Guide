using System;

class CountInst
{
    static int count = 0;

    // increment count when object is created 
    public CountInst()
    {
        count++;
    }

    // decrement count when object is destroyed 
    ~CountInst()
    {
        count--;
    }

    public static int getcount()
    {
        return count;
    }
}

class MainClass
{
    public static void Main()
    {
        CountInst ob;


        for (int i = 0; i < 10; i++)
        {
            ob = new CountInst();
            Console.WriteLine("Current count: " +
                              CountInst.getcount());
        }

    }
}

//Current count: 1
//Current count: 2
//Current count: 3
//Current count: 4
//Current count: 5
//Current count: 6
//Current count: 7
//Current count: 8
//Current count: 9
//Current count: 10
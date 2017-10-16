using System;

class Destruct
{
    public int x;

    public Destruct()
    {
  
    }

    public Destruct(int i)
    {
        x = i;
    }

    // called when object is recycled 
    ~Destruct()
    {
        Console.WriteLine("Destructing " + x);
    }
}

class DestructDemo
{
    public static void Main()
    {
        Destruct ob = new Destruct(0);

        for (int i = 1; i < 100; i++)
        {
           // Destruct o = new Destruct();
            Destruct o = new Destruct(i);
        }
        Console.WriteLine("Done");
    }
}

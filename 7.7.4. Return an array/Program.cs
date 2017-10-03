using System;

class Factor
{

    //çarpanlara ayırma işlemi
    public int[] findfactors(int num, out int numfactors)
    {
        int[] facts = new int[80];
        int i, j;

        for (i = 2, j = 0; i < num / 2 + 1; i++)
            if ((num % i) == 0)
            {
                facts[j] = i;
                j++;
            }

        numfactors = j;
        return facts;
    }
}

class MainClass
{
    public static void Main()
    {
        Factor f = new Factor();
        int numfactors;
        int[] factors;

        factors = f.findfactors(1000, out numfactors);

        Console.WriteLine("Factors for 1000 are: ");
        for (int i = 0; i < numfactors; i++)
            Console.Write(factors[i] + " ");


        //factors= deneme();
        Console.WriteLine();
    }


    //static int[] deneme()
    //{
    //    int[] x = new int[20];
        
    //    for(int fl=0; fl<x.Length; fl++)
    //    {
    //        x[fl] = fl;

    //    }


    //    return x;


        
    }
}
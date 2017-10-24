using System;


//Using Indexers
/*
 * Indexers are a syntactic convenience that enable you to create a class, 
 * struct, or interface that client applications can access just as an array. 
 * Indexers are most frequently implemented in types whose primary purpose is to encapsulate 
 * an internal collection or array. For example, suppose you have a class named TempRecord 
 * that represents the temperature in Farenheit as recorded at 10 different times during a 24 hour period. 
 * The class contains an array named "temps" of type float to represent the temperatures, 
 * and a DateTime that represents the date the temperatures were recorded. 
 * By implementing an indexer in this class,
 * clients can access the temperatures in a TempRecord instance as float temp = tr[4] instead of as float temp = tr.temps[4]. 
 * The indexer notation not only simplifies the syntax for client applications; 
 * it also makes the class and its purpose more intuitive for other developers to understand. 
+ 
To declare an indexer on a class or struct, use the this keyword, as in this example: 
 * public int this[int index]    // Indexer declaration  
{  
    // get and set accessors  
}*/

class MyArray
{
    int[] a;
    int len;

    public bool errflag;

    public MyArray(int size)
    {
        a = new int[size];
        len = size;
    }

    public int Length
    {
        get
        {
            return len;
        }
    }

    public int this[int index]
    {
        get
        {
            if (indexCheck(index))
            {
                errflag = false;
                return a[index];
            }
            else
            {
                errflag = true;
                return 0;
            }
        }

        set
        {
            if (indexCheck(index))
            {
                a[index] = value;
                errflag = false;
            }
            else errflag = true;
        }
    }

    private bool indexCheck(int index)
    {
        if (index >= 0 & index < Length)
            return true;
        return false;
    }
}

class MainClass
{
    public static void Main()
    {
        MyArray myArray = new MyArray(5);
        int x;

        for (int i = 0; i < myArray.Length; i++)
            myArray[i] = i * 10;

        for (int i = 0; i < myArray.Length; i++)
        {
            x = myArray[i];
            if (x != -1) Console.Write(x + " ");
        }
        Console.WriteLine();

    }
}

//0 10 20 30 40

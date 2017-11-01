using System;
public class NotDisposible { }
//7.53.2.	Use Not Disposible object in using statement

public class MainClass
{
    public static void Main(string[] args)
    {

        // Uncomment to trigger compile time error.
        // using(NotDisposible x = new NotDisposible()){}

    }
}
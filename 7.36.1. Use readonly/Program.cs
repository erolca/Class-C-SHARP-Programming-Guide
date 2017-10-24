using System;

/*  You can create a read-only field in a class by declaring it as readonly.    */
/*  A readonly field can be initialized, but not changed after that.            */

class MainClass
{
    public static readonly int SIZE = 10;

    public static void Main()
    {
        int[] nums = new int[MainClass.SIZE];

        // MainClass.SIZE = 100; // Error!!! can't change 
    }
}
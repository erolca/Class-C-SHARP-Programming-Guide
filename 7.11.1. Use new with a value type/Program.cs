using System;
/*
 * The new operator has this general form:
 * class-var = new class-name( );
 * The class-var is a variable of the class type being created.
 * The class-name is the name of the class that is being instantiated.
 * The class name followed by parentheses specifies the constructor for the class.
 */

class MainClass
{
    public static void Main()
    {
        int i = new int(); // initialize i to zero 
        i = 32;
        Console.WriteLine("The value of i is: " + i);

        i = new int();
        Console.WriteLine("The value of i is: " + i);

    }
}

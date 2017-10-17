using System;


//The internal modifier declares that a member is known throughout all files in an assembly, but unknown outside that assembly.
//The protected internal access level can be given only to class members.
//A member declared with protected internal access is accessible within its own assembly or to derived types.

class InternalTest
{
    internal int x;
}

class MainClass
{
    public static void Main()
    {
        InternalTest ob = new InternalTest();

        ob.x = 10; // can access -- in same file 

        Console.WriteLine("Here is ob.x: " + ob.x);

    }
}
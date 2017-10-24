using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 
Note+
The readonly keyword is different from the const keyword.
A const field can only be initialized at the declaration of the field. 
A readonly field can be initialized either at the declaration or in a constructor.
Therefore, readonly fields can have different values depending on the constructor used. Also, 
while a const field is a compile-time constant, 
the readonly field can be used for runtime 
constants as in the following example:

public static readonly uint timeStamp = (uint)DateTime.Now.Ticks;  
     
*/

public class ReadOnlyTest
{
    class SampleClass
    {
        public int x;
        // Initialize a readonly field
        public readonly int y = 25;
        public readonly int z;

        public SampleClass()
        {
            // Initialize a readonly instance field
            z = 24;
        }

        public SampleClass(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p3;
        }
    }

    static void Main()
    {
        SampleClass p1 = new SampleClass(11, 21, 32);   // OK
        Console.WriteLine("p1: x={0}, y={1}, z={2}", p1.x, p1.y, p1.z);
        SampleClass p2 = new SampleClass();
        p2.x = 55;   // OK
        Console.WriteLine("p2: x={0}, y={1}, z={2}", p2.x, p2.y, p2.z);
    }
}
/*
 Output:
    p1: x=11, y=21, z=32
    p2: x=55, y=25, z=24
*/

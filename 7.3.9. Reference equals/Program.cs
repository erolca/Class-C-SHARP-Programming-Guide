using System;
using System.Text;

public class MyClass
{
    //public string Owner { get; set; } = "No Owner";

    public MyClass()
    {
         
    }

}

public class MainClass
{
    static void Main()
    {
        MyClass referenceA = new MyClass();
        MyClass referenceB = new MyClass();

        System.Console.WriteLine("Result of Equality is {0}", referenceA == referenceB);

        /*
         * https://msdn.microsoft.com/en-us/library/system.string.intern.aspx
         */
        string s1 = "MyTest";
        string s2 = new StringBuilder().Append("My").Append("Test").ToString();
        string s3 = String.Intern(s2);
        Console.WriteLine((Object)s2 == (Object)s1); // Different references.
        Console.WriteLine((Object)s3 == (Object)s1); // The same reference.

        s1 = "MyTest";
        s2 = new StringBuilder().Append("My").Append("Test").ToString();
        s3 = String.Intern(s2);
        Console.WriteLine("s1 == '{0}'", s1);
        Console.WriteLine("s2 == '{0}'", s2);
        Console.WriteLine("s3 == '{0}'", s3);
        Console.WriteLine("Is s2 the same reference as s1?: {0}", (Object)s2 == (Object)s1);
        Console.WriteLine("Is s3 the same reference as s1?: {0}", (Object)s3 == (Object)s1);
        /*
            This example produces the following results:
            s1 == 'MyTest'
            s2 == 'MyTest'
            s3 == 'MyTest'
            Is s2 the same reference as s1?: False
            Is s3 the same reference as s1?: True
        */

    }
}




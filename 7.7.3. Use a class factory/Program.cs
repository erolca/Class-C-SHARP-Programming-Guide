using System;

class MyClass
{
    int a, b; // private 

    // Create a class factory for MyClass. 
    public MyClass factory(int i, int j)
    {
        MyClass t = new MyClass();
   
        t.a = i;
        t.b = j;

        return t; // return an object 
    }

    public void show()
    {
        Console.WriteLine("a and b: " + a + " " + b);
    }

}

class MakeObjects
{
    public static void Main()
    {
        
        MyClass ob = new MyClass();
        int i, j;

        // generate objects using the factory 
        for (i = 0, j = 9999; i < 9999; i++, j--)
        {
         
            MyClass anotherOb = ob.factory(i, j); // make an object 
            anotherOb.show();
        }

        Console.WriteLine();


        Console.ReadKey();

    }
}

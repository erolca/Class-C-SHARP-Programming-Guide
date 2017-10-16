using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MyClass
{
    private static int numberOfMyClass = 0;

    public MyClass()
    {

        numberOfMyClass++;
        System.Console.WriteLine("Creating a MyClass object {0}", numberOfMyClass);
        
    }

    ~MyClass()
    {

        numberOfMyClass--;  // decrement numberOfMyClass
        System.Console.WriteLine("Destroying a MyClass object {0}", numberOfMyClass);
        
    }

    public static int GetNumberOfMyClass()
    {
        return numberOfMyClass;
    }

}


class MainClass
{

    public static void Main()
    {
        //System.Console.WriteLine("MyClass.GetNumberOfMyClass() = " + MyClass.GetNumberOfMyClass());

        MyClass myMyClass = new MyClass();
        System.Console.WriteLine("MyClass.GetNumberOfMyClass() = " + MyClass.GetNumberOfMyClass());

        MyClass myMyClass2 = new MyClass();
        System.Console.WriteLine("MyClass.GetNumberOfMyClass() = " + MyClass.GetNumberOfMyClass());
    }
}
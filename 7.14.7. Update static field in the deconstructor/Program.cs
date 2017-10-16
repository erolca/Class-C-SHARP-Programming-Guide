using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MyClass
{
    private static int numberOfMyClass = 0;

    public MyClass()
    {
        System.Console.WriteLine("Creating a MyClass object");
        numberOfMyClass++;
    }

    ~MyClass()
    {
        System.Console.WriteLine("Destroying a MyClass object");
        numberOfMyClass--;  // decrement numberOfMyClass
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
        System.Console.WriteLine("MyClass.GetNumberOfMyClass() = " + MyClass.GetNumberOfMyClass());

        MyClass myMyClass = new MyClass();
        System.Console.WriteLine("MyClass.GetNumberOfMyClass() = " + MyClass.GetNumberOfMyClass());

        MyClass myMyClass2 = new MyClass();
        System.Console.WriteLine("MyClass.GetNumberOfMyClass() = " + MyClass.GetNumberOfMyClass());
    }
}
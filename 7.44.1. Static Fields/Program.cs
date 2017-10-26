using System;
/*
 
1-  A static member can be accessed before any objects of its class are created.
2-  You can call a static member without referencing to any object.
3-  You can declare both static methods and static variables.
4-  Variables declared as static are, essentially, global variables.
5-  All instances of the class share the same static variable.
6-  A static variable is initialized when its class is loaded.
7-  A static variable always has a value.
8-  If not initialized, a static variable is initialized to zero for numeric values.
9-  If not initialized, a static variable is initialized to null for object references.
10- If not initialized, a static variable is initialized to false for variables of type bool.
     
     
     
     
     
     */
class MyClass
{
    public MyClass()
    {
        instanceCount++;
    }
    public static int instanceCount = 0;
}

class MainClass
{
    public static void Main()
    {
        MyClass my = new MyClass();
        Console.WriteLine(MyClass.instanceCount);
        MyClass my2 = new MyClass();
        Console.WriteLine(MyClass.instanceCount);
        
    }
}

//1
//2
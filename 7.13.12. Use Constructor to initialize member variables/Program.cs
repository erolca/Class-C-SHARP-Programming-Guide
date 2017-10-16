using System;

class MyClass
{
    public int[] MyIntArray;
    public int Y;
    public int ObjectCount = 0;

    public MyClass()
    {
        MyIntArray = new int[10];
        //Do work necessary during object creation
    }
    //Overloads the MyClass allowing you to initialize Y
    public MyClass(int myY)
    {
        Y = myY;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        MyClass X = new MyClass();

        X.ObjectCount++;

        MyClass YY = new MyClass(10);
    }

}
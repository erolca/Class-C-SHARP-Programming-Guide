using System;

class MyClass
{
    public int x;

    public MyClass()
    {
        Console.WriteLine("Normal Constructer...");
    }
    static MyClass()
    {
        Console.WriteLine("Static Constructer...");
    }

   

}

class A
{
public int x { get; set; }
   


}

class B : A
{

    public int y { get; set; }


}

class MainClass
{
    public static void Main()
    {
        MyClass a = new MyClass();
        MyClass b = new MyClass();

        a.x = 10;
        b.x = 20;
     

        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

        a = b;
        b.x = 30;

        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);


        A ab = new B();
        B ba= (B)ab; // downcast
        B b1 = new B();
        A a1 = b1;//upcast
        
       
        
    }
}




//a.x 10, b.x 20
//a.x 30, b.x 30
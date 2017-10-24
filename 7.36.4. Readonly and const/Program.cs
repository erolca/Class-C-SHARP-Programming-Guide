
/*
 The readonly keyword is a modifier that you can use on fields.
 When a field declaration includes a readonly modifier, 
 assignments to the fields introduced by the declaration can only occur as part of the declaration 
 or in a constructor in the same class.
 */
public class MyClass
{
    public MyClass()
    {
        this.y = 4;
        this.y = 6;

        SetField(ref this.y);
    }

    private void SetField(ref int val)
    {
        val = 8;
    }

    public readonly int x = 123;
    public readonly int y;
    public const int z = 555;

}

public class MainClass
{
    static void Main()
    {
        MyClass obj = new MyClass();

        // obj.y = 5;// Error!!! can't change 

        System.Console.WriteLine("x = {0}, y = {1}, z = {2}", obj.x, obj.y, MyClass.z);
    }

}
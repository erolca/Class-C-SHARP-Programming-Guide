using System;
class MyClass
{

    // Fields
    public string               publicStringField;
    protected internal string   protectedInternalStringField;
    internal string             internalStringField;
    protected int               protectedField = 150;
    private int                 privateField;



    //Methods
    public void setPrivateField(int privateField)
    {
        this.privateField = privateField;
    }

    
    public int getPrivateField()
    {
        return privateField;
    }

    public void Start()
    {
        System.Console.WriteLine("Starting MyClass ...");
        privateMethod();
        System.Console.WriteLine("MyClass started");
    }

    private void privateMethod()
    {
        System.Console.WriteLine("Turning starter motor ...");
    }

}


class MainClass
{
    public static void Main()
    {
        MyClass myMyClass = new MyClass();

        myMyClass.publicStringField                     = "Toyota";
        myMyClass.protectedInternalStringField          = "MR2";
        myMyClass.internalStringField                   = "black";

        myMyClass.setPrivateField(1995);

        System.Console.WriteLine("myMyClass.publicStringField = "               + myMyClass.publicStringField);
        System.Console.WriteLine("myMyClass.protectedInternalStringField = "    + myMyClass.protectedInternalStringField);
        System.Console.WriteLine("myMyClass.internalStringField = "             + myMyClass.internalStringField);

        System.Console.WriteLine("myMyClass.getPrivateField() = "               + myMyClass.getPrivateField());

        myMyClass.Start();
    }
}
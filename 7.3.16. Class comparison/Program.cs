using System;

class ComparingRelations
{
    static void Main(string[] args)
    {
        int a = 12;
        int b = 12;
        Console.WriteLine(a == b);
        Console.WriteLine((object)a == (object)b);


        string c = "hello";
        string d = "hello";
        Console.WriteLine((object)c == (object)d);

        ClassCompare x = new ClassCompare();
        ClassCompare y;
        x.val = 1;
        y = x;
        Console.WriteLine(x == y);

        x.val = 2;
        Console.WriteLine(y.val.ToString());
    }
}
class ClassCompare
{
    public int val = 0;
}
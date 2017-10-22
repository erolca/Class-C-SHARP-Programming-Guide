using System;

public interface Channel
{
    void Next();
    void Previous();
}

public interface Book
{
    void Next();
    void Chapter();
}

public class MainClass : Channel, Book
{
    void Channel.Next()
    {
        Console.WriteLine("Channel Next");
    }
    void Book.Next()
    {
        Console.WriteLine("Book Next");
    }
    public void Previous()
    {
        Console.WriteLine("Previous");
    }
    public void Chapter()
    {
        Console.WriteLine("Chapter");
    }

    public static void Main()
    {
        MainClass app = new MainClass();
        ((Book)app).Next();
        ((Channel)app).Next();
        app.Previous();
        app.Chapter();
    }
}
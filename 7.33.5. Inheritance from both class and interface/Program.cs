using System;

public interface IDataBound
{
    void Serialize();
}


public class Control
{
    public void Serialize()
    {
        Console.WriteLine("Control.Serialize called");
    }
}


public class EditBox : Control, IDataBound
{
}

class InterfaceInh2App
{
    public static void Main()
    {
        EditBox edit = new EditBox();

        IDataBound bound = edit as IDataBound;
        if (bound != null)
        {
            Console.WriteLine("IDataBound is supported...");
            bound.Serialize();
        }
        else
        {
            Console.WriteLine("IDataBound is NOT supported...");
        }
    }
}
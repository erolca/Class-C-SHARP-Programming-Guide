using System;

class RevStr
{

    public void displayRev(string str)
    {
        if (str.Length > 0)
            displayRev(str.Substring(1, str.Length - 1));
        else
            return;

        Console.Write(str[0]);
    }
}

class MainClass
{
    public static void Main()
    {
        string s = "this is a test";
        RevStr rsOb = new RevStr();

        Console.WriteLine("Original string: " + s);

        Console.Write("Reversed string: ");
        rsOb.displayRev(s);

        Console.WriteLine();
    }
}

//Original string: this is a test
//Reversed string: tset a si siht
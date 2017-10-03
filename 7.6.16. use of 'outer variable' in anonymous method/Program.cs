using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    delegate void MessagePrintDelegate(string msg);

    static void Main(string[] args)
    {
        string source = "Outer";

        MessagePrintDelegate mpd3 = delegate (string msg)
        {
            Console.WriteLine("[{0}] {1}", source, msg);
        };
        LongRunningMethod(mpd3);

    }

    static void LongRunningMethod(MessagePrintDelegate mpd)
    {
        for (int i = 0; i < 99; i++)
        {
            if (i % 25 == 0)
            {
                mpd(string.Format("Progress Made. {0}% complete.", i));
            }
        }
    }

    static void PrintMessage(string msg)
    {
        Console.WriteLine("[PrintMessage] {0}", msg);
    }
}
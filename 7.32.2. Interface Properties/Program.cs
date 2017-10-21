using System;
public interface ILog
{
    int OpenLogFile(string fileName);
    int CloseLogFile();
    void LogString(string strToLog);
}


public class MyLog : ILog
{
    public int OpenLogFile(string fileName)
    {
        Console.WriteLine("Opening File {0}", fileName);
        return 0;
    }
    public int CloseLogFile()
    {
        Console.WriteLine("Closing log file");
        return 0;
    }
    public void LogString(string strToLog)
    {
        Console.WriteLine("Logging String {0}", strToLog);
    }
}


class MainClass
{
    public static void Main()
    {
        MyLog app = new MyLog();
        app.OpenLogFile("AFile");
        app.LogString("Hello world");
        app.CloseLogFile();
    }
}
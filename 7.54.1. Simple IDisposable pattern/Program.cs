using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Security.Cryptography;

class MyClass : IDisposable
{
    private Stream myStream = null;

    public void Dispose()
    {
        Stream s = myStream;
        if (s != null)
            ((IDisposable)s).Dispose();
    }
}

public class MainClass
{
    public static void Main()
    {
        using (MyClass mc = new MyClass())
        {
        }
    }

}
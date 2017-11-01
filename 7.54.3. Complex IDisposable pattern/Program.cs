using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Security.Cryptography;

class MyClass : IDisposable
{
    private IntPtr myHandle = IntPtr.Zero;
    ~MyClass()
    {
        Dispose(false);
    }

    public IntPtr MyHandle { get => myHandle; set => myHandle = value; }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected void Dispose(bool disposing)
    {
        IntPtr h = MyHandle;
        if (h != IntPtr.Zero)
        {
            h = IntPtr.Zero;
        }
    }
}




public class MainClass
{

    private const int GW_OWNER = 4;
    [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
    public static extern IntPtr GetWindow(IntPtr hwnd, int wFlag);


    public static void Main()
    {
        using (MyClass mc = new MyClass())
        {
            mc.MyHandle = new IntPtr(3);
            //https://msdn.microsoft.com/tr-tr/library/system.intptr.zero(v=vs.110).aspx
            IntPtr hwnd = new IntPtr(3);
            IntPtr hOwner = GetWindow(hwnd, GW_OWNER);
            if (hOwner == IntPtr.Zero)
                Console.WriteLine("Window not found.");
            // The example displays the following output:
            //        Window not found.

        }

    }

}
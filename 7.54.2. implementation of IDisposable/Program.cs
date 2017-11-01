using System;

class MyClass : IDisposable
{
    private bool Disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);


    }
    private void Dispose(bool disposing)
    {
        if (!this.Disposed)
        {
            if (disposing)
            {
                //free any managed resources
            }

            //free unmanaged resources
        }

        Disposed = true;
    }
    ~MyClass()
    {
        Dispose(false);
    }
}

class Program
    {
        static void Main(string[] args)
        {

        MyClass d = new MyClass();
        d.Dispose();
        }
    }


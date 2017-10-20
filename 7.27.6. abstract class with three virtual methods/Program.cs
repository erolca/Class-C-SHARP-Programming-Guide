using System;


public abstract class MyOperations
{
    public virtual void Operation1()
    {
    }

    public virtual void Operation2()
    {
    }

    public virtual void Operation3()
    {
    }
}

public class MyClass : MyOperations
{
    public override void Operation1() { }
    public override void Operation2() { }
}

public class MainClass
{
    public void DoWork(MyOperations ops)
    {
        ops.Operation3();
    }
}
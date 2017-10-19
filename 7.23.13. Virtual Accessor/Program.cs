using System;

public class Class1
{
    public static void Main(string[] strings)
    {
        MyMoney dm = new MyMoney();
        dm.CurrencyValue = 2.50M;
        Console.WriteLine(dm.CurrencyValue);

        Dollar dollar = new Dollar();
        dollar.InitDollar(1.2M);

        dollar.EuroValue = dm.EuroValue;
        Console.WriteLine(dollar.CurrencyValue);

        dollar.CurrencyValue = 2 * dollar.CurrencyValue;
        dm.EuroValue = dollar.EuroValue;
        Console.WriteLine(dm.CurrencyValue);

    }
}

abstract public class Currency
{
    private decimal mEuroValue = 0M; // [Euro]

    public abstract decimal CurrencyValue { get; set; }
    public decimal EuroValue
    {
        get
        {
            return mEuroValue;
        }
        set
        {
            mEuroValue = value;
        }
    }
}

public class MyMoney : Currency
{
    private static decimal mDMtoEuro = 1.96M;
    public override decimal CurrencyValue
    {
        get { return EuroValue * mDMtoEuro; }
        set { EuroValue = value / mDMtoEuro; }
    }
}

public class Dollar : Currency
{
    public decimal mDollartoEuroConversion;

    public void InitDollar(decimal mDollartoEuro)
    {
        mDollartoEuroConversion = mDollartoEuro;
    }

    public override decimal CurrencyValue
    {
        get { return EuroValue * mDollartoEuroConversion; }
        set { EuroValue = value / mDollartoEuroConversion; }
    }
}
using System;
public class BankAccount
{
    static int nNextAccountNumber = 100;

    int nAccountNumber;
    double dBalance;

    public BankAccount() : this(0, 0) { }

    public BankAccount(double dInitialBalance) :
        this(0, dInitialBalance)
    {


    }


    public BankAccount(int nInitialAccountNumber,double dInitialBalance)
    {
        if (nInitialAccountNumber <= 0)
        {
            nInitialAccountNumber = ++nNextAccountNumber;
        }
        nAccountNumber = nInitialAccountNumber;
        if (dInitialBalance < 0)
        {
            dInitialBalance = 0;
        }
        dBalance = dInitialBalance;
    }

    public string GetString()
    {
        return String.Format("#{0} = {1:N}",
                              nAccountNumber, dBalance);
    }
}

class MainClass
{


    public static void Main()
    {

        BankAccount d = new BankAccount(250.5);
        Console.Write(d.GetString());

    }

}
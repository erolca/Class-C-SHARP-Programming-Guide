using System;

class Stack
{
    char[] stck; // holds the stack  
    int tos;     // index of the top of the stack  

    public Stack(int size)
    {
        stck = new char[size];
        tos = 0;
    }

    public Stack(Stack ob)
    {
        stck = new char[ob.stck.Length];

        for (int i = 0; i < ob.tos; i++)
            stck[i] = ob.stck[i];

        tos = ob.tos;
    }

    public void push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine(" -- Stack is full.");
            return;
        }

        stck[tos] = ch;
        tos++;
    }

    public char pop()
    {
        if (tos == 0)
        {
            Console.WriteLine(" -- Stack is empty.");
            return (char)0;
        }

        tos--;
        return stck[tos];
    }

    public bool full()
    {
        return tos == stck.Length;
    }

    public bool empty()
    {
        return tos == 0;
    }

    public int capacity()
    {
        return stck.Length;
    }

    public int getNum()
    {
        return tos;
    }
}// end of stack




class MainClass
{
    public static void Main()
    {
        Stack stk1 = new Stack(10);
        char ch;
        int i;

        Console.WriteLine("Push A through J onto stk1.");
        for (i = 0; !stk1.full(); i++)
            stk1.push((char)('A' + i));

        Stack stk2 = new Stack(stk1);

        Console.Write("Contents of stk1: ");
        while (!stk1.empty())
        {
            ch = stk1.pop();
            Console.Write(ch);
        }

        Console.WriteLine();

        Console.Write("Contents of stk2: ");
        while (!stk2.empty())
        {
            ch = stk2.pop();
            Console.Write(ch);
        }

        Console.WriteLine("\n");

    }
}
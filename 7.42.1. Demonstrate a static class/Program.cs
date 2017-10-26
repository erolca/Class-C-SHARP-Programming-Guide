using System;

static class MathFunction
{
    // Return the reciprocal of a value. 
    static public double reciprocal(double num)
    {
        return 1 / num;
    }

    // Return the fractional part of a value. 
    static public double fracPart(double num)
    {
        return num - (int)num;
    }

    // Return true if num is even. 
    static public bool isEven(double num)
    {
        return (num % 2) == 0 ? true : false;
    }

    // Return true of num is odd. 
    static public bool isOdd(double num)
    {
        return !isEven(num);
    }

}

class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Reciprocal of 5 is " +
                          MathFunction.reciprocal(5.0));

        Console.WriteLine("Fractional part of 4.234 is " +
                          MathFunction.fracPart(4.234));

        if (MathFunction.isEven(10))
            Console.WriteLine("10 is even.");

        if (MathFunction.isOdd(5))
            Console.WriteLine("5 is odd.");

        // The following attempt to create an instance of  
        // MathFunction will cause an error. 
        //  MathFunction ob = new MathFunction(); // Wrong! 
    }
}

//Reciprocal of 5 is 0.2
//Fractional part of 4.234 is 0.234
//10 is even.
//5 is odd.
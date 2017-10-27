using System;

public sealed class ComplexNumber
{
    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public override int GetHashCode()
    {
        return (int)Math.Sqrt(Math.Pow(this.real, 2) * Math.Pow(this.imaginary, 2));
    }

    private readonly double real;
    private readonly double imaginary;
}

class MyClass
{


    public static void Main()
    {

        ComplexNumber d = new ComplexNumber(5, 6);
        Console.WriteLine("{0}",d.GetHashCode());

    }

}
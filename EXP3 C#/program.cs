
using System;

class Number
{
    int value;

    public Number(int v)
    {
        value = v;
    }

    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.value + n2.value);
    }

    public static Number operator -(Number n1, Number n2)
    {
        return new Number(n1.value - n2.value);
    }

    public static Number operator *(Number n1, Number n2)
    {
        return new Number(n1.value * n2.value);
    }

    public void Display()
    {
        Console.WriteLine(value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Number n1 = new Number(a);
        Number n2 = new Number(b);

        Number sum = n1 + n2;
        Number diff = n1 - n2;
        Number product = n1 * n2;

        Console.Write("Addition = ");
        sum.Display();

        Console.Write("Subtraction = ");
        diff.Display();

        Console.Write("Multiplication = ");
        product.Display();
    }
}


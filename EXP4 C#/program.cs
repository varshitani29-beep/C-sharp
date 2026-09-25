using System;

public delegate void ProductDetails();

class Shopping
{
    public static void Product1()
    {
        Console.WriteLine("Product : Laptop");
        Console.WriteLine("Price : Rs.50000");
        Console.WriteLine("Quantity: 1");
        Console.WriteLine("Brand : Dell");
    }

    public static void Product2()
    {
        Console.WriteLine("Product : Mouse");
        Console.WriteLine("Price : Rs.800");
        Console.WriteLine("Quantity: 2");
        Console.WriteLine("Brand : Logitech");
    }

    static void Main(string[] args)
    {
        ProductDetails pd = Product1;

        Console.WriteLine("Product 1 Details");
        pd();

        Console.WriteLine("----------------");

        pd = Product2;

        Console.WriteLine("Product 2 Details");
        pd();

        Console.ReadLine();
    }
}
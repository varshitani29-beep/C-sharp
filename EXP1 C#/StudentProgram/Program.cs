using System;

class Student
{
    int rollNo;
    string name;
    int mark1, mark2, mark3;
    int total;
    double average;

    public void GetData()
    {
        Console.Write("Enter Roll Number: ");
        rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Mark 1: ");
        mark1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 2: ");
        mark2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 3: ");
        mark3 = Convert.ToInt32(Console.ReadLine());
    }

    public void Calculate()
    {
        total = mark1 + mark2 + mark3;
        average = total / 3.0;
    }

    public void Display()
    {
        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Roll Number : " + rollNo);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Average : " + average);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.GetData();
        s.Calculate();
        s.Display();

        Console.ReadLine();
    }
}

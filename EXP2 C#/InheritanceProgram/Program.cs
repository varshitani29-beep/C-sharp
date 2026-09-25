using System;

class Person
{
    public string Name = "Bob";
    public int Age = 20;

    public void DisplayPerson()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age : " + Age);
    }
}

class Student : Person
{
    public int RollNo = 101;

    public void DisplayStudent()
    {
        Console.WriteLine("Roll No : " + RollNo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.DisplayPerson();
        s.DisplayStudent();

        Console.ReadLine();
    }
}

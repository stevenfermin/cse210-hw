using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("Please enter your first name:");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        string lastname = Console.ReadLine();

        Console.WriteLine("Your name is " + lastname + ", " + name + " " + lastname);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        string letter = "";
        string sign = "";
        int grade = 0;
        
        Console.WriteLine("Please enter your grade:");
        grade = int.Parse(Console.ReadLine());
        int remainder = grade % 10;

        if (grade >= 90)
        {
            letter = "A";
            if (remainder <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations! You received an " + letter + sign + ".");
        }
        else if (letter == "D")
        {
            Console.WriteLine("You received an " + letter + sign + ". But don't give up! Good luck!");
        }
        else
        {
            Console.WriteLine("You received an " + letter + ". But don't give up! Good luck!");
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
            else if (number == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }

        } while (number != 0);

        // Calculate the sum of the numbers
        float sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine("The sum of the numbers is: " + sum);

        // Calculate the average
        int count = numbers.Count;
        float average = sum / count;
        Console.WriteLine("The average of the numbers is: " + average);

        // Calculate the largest number
        int largest = 0;
        
        foreach (int  n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }
        Console.WriteLine("The largest number is: " + largest);

        int spositive = largest;

        foreach (int n in numbers)
        {
            if (n < spositive && n > 0)
            {
                spositive = n;
            }
        }
        Console.WriteLine("The smallest positive number is: " + spositive);

        numbers.Sort();
        Console.WriteLine("The sorted numbers is:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
            
        }
        
    }
}
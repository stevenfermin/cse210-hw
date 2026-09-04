using System;

class Program
{   
    static void Main(string[] args)
    {
        Random randomnumber = new Random();
        int number =  randomnumber.Next(1, 101);
        int guess = 0;
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Welcome to tricky number");
        Console.WriteLine("Please enter your guess between 1 and 100:");
        bool open = true;
        while (open == true)
        {
            do
            {
                guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess: " + guess);
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Your guess: " + guess);
                    Console.WriteLine("Lower");
                }
                
            } while (guess != number);
            Console.WriteLine("Do you want to play again? (Yes/No)");
            string playAgain = Console.ReadLine();
            if (playAgain == "No" || playAgain == "no" || playAgain == "NO" || playAgain == "N" || playAgain == "n")
            {
                open = false;
            }
        }
        
    }
}
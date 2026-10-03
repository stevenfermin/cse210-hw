using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    static void Main(string[] args)
    {
        bool condition = true;
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while (condition == true)
        {
            Console.Clear();
            Console.WriteLine("Please choose an activity to perform: \n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Exit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity("Welcome to the Breathing Activity", "This activity will help you relax by an exercise of reducing estress and anxiety through deep breathing.");
                    break;
                case 2:
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Welcome to the Reflecting Activity", "This activity will help you reflect on your experiences and personal growth.");
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity("Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life.");
                    break;
                default:
                    Console.WriteLine("Invalid activity type. Please choose 'breathing', 'reflecting', or 'listing'.");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Exiting the program. Goodbye!");
                    condition = false;
                    break;
            }
        }
    }
    public int GetDuration()
    {
        return _duration;
    }

    public int SetDuration(int duration)
    {
        _duration = duration;
        return _duration;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
    }
    
    public void DisplayEndingMessage()
    {
        Console.Write("\n\nWell done!");
        Console.WriteLine($" You have completed the {_name}.");
        Console.WriteLine($"You have spent {_duration} seconds on this activity.");
    }

    public void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.Write(" ");
    }

    public void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b\b");
        }
    }
}


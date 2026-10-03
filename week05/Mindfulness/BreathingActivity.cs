using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));
        run();
    }

    public void run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        int breathduration = GetDuration() / 10;
        for (int i = 0; i < breathduration; i++)
        {
            
            Console.Write("\n\nBreathe in...");
            for (int j = 4; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nBreathe out...");
            for (int j = 6; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }

    
}
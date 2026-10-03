public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>
    {
        "> Why was this experience meaningful to you? ",
        "> Have you ever done anything like this before? ",
        "> How did you get started? ",
        "> What made this time different than other times when you were not as successful? ",
        "> What is your favorite thing about this experience? ",
        "> What could you learn from this experience that applies to other situations? ",
        "> What did you learn about yourself through this experience? ",
        "> How can you keep this experience in mind in the future? "
    };

    private List<string> _prompts = new List<string>
    {
        "--------Think of a time when you stood up for someone else--------",
        "--------Think of a time when you did something really difficult..--------",
        "--------Think of a time when you helped someone in need..--------",
        "--------Think of a time when you did something truly selfless.--------"
    };
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        DisplayStartingMessage();
        Console.Write("\nFor how long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));
        run();
    }

    public void run()
    {
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        // Start the countdown for the reflection activity
        ShowSpinner(5); // 5 seconds for reflection

        Console.WriteLine("\nTake a moment to reflect on the following prompt:\n");
        // Display a prompt for the user to reflect on
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, take a moment to answer the following questions related to your experience:");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(1000); // Wait for 1 second
            Console.Write("\b\b"); // Erase the previous number
        }
        Console.Clear();
        int questionDuration = GetDuration() / 10; // Divide the total duration by the number of questions
        int ponderDuration = questionDuration * 10 / questionDuration;
        for (int i = 0; i < questionDuration; i++)
        {
            DisplayQuestions();
            ShowSpinner(ponderDuration); // Wait for the ponder duration before displaying the next question
            Console.WriteLine();
        }

        // After the countdown, display a message indicating the end of the activity
        DisplayEndingMessage();
        ShowSpinner(5); // Show spinner for 5 seconds after completing the reflection activity
    }
    
    public void DisplayPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);
    }

    public void DisplayQuestions()
    {
        Random random = new Random();
        int questionIndex = random.Next(_questions.Count);
        Console.Write(_questions[questionIndex]);
    }
}
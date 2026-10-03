public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
        {
            "-----List as many things as you can that you are grateful for.-----",
            "-----List as many personal strengths as you can.-----",
            "-----List as many people who have positively influenced your life.-----",
            "-----List as many accomplishments you are proud of.-----",
            "-----List as many things that make you happy.-----"
        };

    public ListingActivity(string name, string description) : base(name, description)
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
        Console.WriteLine();
        
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _prompts.Add(Console.ReadLine());
        }
    
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public void GetRandomPrompt()
    {
        

        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomPromptIndex]);
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}
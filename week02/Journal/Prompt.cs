using System;
using System.Security.Cryptography;

//List of prompts
class Prompt
{
    public List<string> promptlist = ["Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"];

    public void prompt_list()
    {
        Random rand = new Random();
        int RandomNumber = rand.Next(5);
        
        string promptresult = promptlist[RandomNumber];
        PromptResult = promptresult;
        Console.WriteLine(promptresult);
    }

    public string PromptResult;
}
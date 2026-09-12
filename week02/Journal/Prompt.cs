using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography;

//List of prompts
public class Prompt
{
    public List<string> promptlist = ["Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"];

    public string answer;
    public string prompt_list()
    {
        Prompt prompt = new Prompt();
        Random rand = new Random();
        int RandomNumber = rand.Next(5);
        
        string promptresult = promptlist[RandomNumber];
        
        return promptresult;
    }

    public void display()
    {
        
        Journal journal = new Journal();
        int listlenght = journal._entries.Count;
        for (int i=0; i< listlenght; i++)
        {
            Console.WriteLine(journal._entries[i]);
        }
    }
}
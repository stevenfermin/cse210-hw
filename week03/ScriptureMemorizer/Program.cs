using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string book = "";
        string chapter = "";
        string verse = "";
        string endVerse = "";
        string scripture = "";

        string _filename ="scripturecite.txt";
        Console.WriteLine();
        List<string> cite = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            cite.Add(line);
        }

        foreach (string word in cite)
        {
            string[] part = word.Split(",");
            book = part[0];
            chapter = part[1];
            verse = part[2];
            endVerse = part[3];
            scripture = part[4];
        }
        string[] words = scripture.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }

        Random rand = new Random();
        int numwords = words.Count();
        int nword = rand.Next(numwords);
        List<int> whided = new List<int>();
        int count = 0;
        bool active = true;
        Console.Write("Please enter something: ");
        string input = Console.ReadLine();
        while (active == true){
            do
            {
                foreach (string word in words)
                {
                    if (whided.Contains(nword))
                {
                    count += 0;
                    cite.Add("_");
                }
                else
                {
                    count +=1;
                    cite.Add(word);
                }
                }
                

            } while (count != 3);
            if (input != "quit")
            {
                active = true;
            }
        }
    }
}
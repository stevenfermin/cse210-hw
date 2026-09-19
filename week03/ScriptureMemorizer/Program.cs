using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        List<string> scripture = new List<string>();
        string _filename = "scripturecite.txt";

        string[] lines = System.IO.File.ReadAllLines(_filename);

        string book = "";
        string chapter = "";
        string startverse = "";
        string endVerse = "";
        string verse = "";

        foreach (string line in lines)
        {
            string[] part = line.Split(",");
            book = part[0];
            chapter = part[1];
            startverse = part[2];
            endVerse = part[3];
            verse = part[4];
        }
        Console.Clear();
        Word word = new Word();
        word._Text = verse;

        Reference reference = new Reference(book, int.Parse(chapter), int.Parse(startverse), int.Parse(endVerse));
        Console.WriteLine(reference.Display());

        Scripture scripture1 = new Scripture();
        scripture1._Words.Add(word);
        scripture1.Display();

        Console.WriteLine("To hide some words, please press Enter. Type 'quit' to close the program:");
        string input = Console.ReadLine();
        if (input != "quit")
        {
            word.hide();
        }
 
    }
}
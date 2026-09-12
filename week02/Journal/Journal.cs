using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

public class Journal
{
    public string _filename;
    public List<string> _entries = new List<string>();
    public void saveFile()
    {
        Console.WriteLine("Please enter the name of the file");
        _filename = Console.ReadLine();

        Console.WriteLine(_entries);
    }

    public void loadFile()
    {
        Console.WriteLine("Please enter the name of the file");
        _filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(_filename);
        
        foreach (string line in lines)
        {
            
        }
    }

    public void displayAll()
    {
        

        string[] lines = System.IO.File.ReadAllLines(_filename);
        
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            
        }
    }

    public string storeEntry(string prompt)
    {
        Console.WriteLine(prompt);
        string answer = Console.ReadLine();
        Prompt prompt1 = new Prompt();
        prompt1.answer = answer;
        string store = $"{prompt}, {answer}";
        _entries.Add(store);

        return _entries.ToString();
    }
}
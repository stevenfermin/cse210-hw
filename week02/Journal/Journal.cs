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

        using (StreamWriter outputfile = new StreamWriter(_filename))
        {
            int lenght = _entries.Count;
            for (int i = 0; i < lenght; i++)
            {
                outputfile.WriteLine(_entries[i]);
            }
        }
    }

    public void loadFile()
    {
        Console.WriteLine("Please enter the name of the file");
        _filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }

    public void displayAll()
    {

        //string[] lines = System.IO.File.ReadAllLines(_filename);
        
        //foreach (string line in lines)
        //{
            //Console.WriteLine(line);
        //    
        //}

        foreach (string line in _entries)
        {
            Console.WriteLine(line);
        }
    }

    public string storeEntry(string prompt)
    {
        string Date = DateTime.Today.ToString("d");
        Console.WriteLine(prompt);
        string answer = Console.ReadLine();
        Prompt prompt1 = new Prompt();
        prompt1.answer = answer;
        string store = $"{Date} {prompt}, {answer}";
        _entries.Add(store);

        

        return _entries.ToString();
    }
}
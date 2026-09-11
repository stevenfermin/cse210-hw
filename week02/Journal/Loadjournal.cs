using System;
using System.IO;
//load the Journal
class Loadjournal
{
    public string _filename;

    public List<string> _Journal = new List<string>();
    public void Ready_journal()
    {   
        Console.WriteLine("Please enter the name of the file");
        _filename = Console.ReadLine();
        Program program = new Program();
        program._journal.Clear();

        string[] lines = System.IO.File.ReadAllLines(_filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(parts);
            string Date = parts[0];
            Console.WriteLine(Date);
            string Prompt = parts[1];
            string Answer = parts[2];
            program._journal.Add($"{Date}{Prompt}{Answer}");
        }
    }
}
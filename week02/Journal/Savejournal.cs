using System;
using System.IO;
using System.Collections.Generic;
// Save the journal
class Savejournal
{
    public string _filename;

    public void saving_journal()
    {
        Console.WriteLine("Please enter the name of the file");
        _filename = Console.ReadLine();

        Program program = new Program();
        Console.WriteLine(program._journal);
        using (StreamWriter outputFile = new StreamWriter(_filename))
    {
        outputFile.WriteLine(program._journal);
        
    }
    } 
}
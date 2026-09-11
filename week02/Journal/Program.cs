using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.IO.Pipelines;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
class Program
{
    
    static void Main(string[] args)
    {
        Program program = new Program();
        Savejournal savejournal = new Savejournal();
        Loadjournal loadjournal = new Loadjournal();
        
        int option;
        Console.WriteLine("Hello World! This is the Journal Project.");
        bool open = true;
        do{
            Console.WriteLine("Please choose an option \n 1. Write in your Journal \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            Console.WriteLine("What would you like to do?");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    program.new_entry();
                    break;
                case 2:
                    program.displayJournal();
                    break;
                case 3:
                    loadjournal.Ready_journal();
                    break;
                case 4:
                    savejournal.saving_journal();
                    break;
                case 5:
                    open = false;
                    break;
            }
        }while (open == true);


    }

    public List<string> _journal = new List<string>();

    public string Date = DateTime.Now.ToString("d");
    public void new_entry()
    {   
        Prompt prompt = new Prompt();
        prompt.prompt_list();
        string Answer = Console.ReadLine();
        string listoutput = prompt.PromptResult;
        _journal.Add(listoutput);
        _journal.Add(Answer);
        
    }

    public void displayJournal()
    {
        //Display
        foreach (string prompt in _journal)
        {
            Console.WriteLine(prompt);
        }
        
        

    }
}
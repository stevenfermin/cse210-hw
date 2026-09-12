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
        Prompt prompt = new Prompt();
        Journal journal = new Journal();
        
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
                    prompt.prompt_list();
                    journal.storeEntry(prompt.prompt_list());
                    break;
                case 2:
                    if (journal._filename == "")
                    {
                        prompt.display();
                    }
                    else
                    {
                    journal.displayAll();
                    }
                    break;
                case 3:
                    journal.loadFile();
                    break;
                case 4:
                    journal.saveFile();
                    break;
                case 5:
                    open = false;
                    break;
            }
        }while (open == true);


    }
}
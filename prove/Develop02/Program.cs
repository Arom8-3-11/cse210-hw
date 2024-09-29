using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // DateTime theCurrentTime = DateTime.Now;
        // public string date = theCurrentTime.ToShortDateString();
        
        // Jounal ajournal = new Journal();


        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("-                                       -");
        Console.WriteLine("     Welcome to the Journal Program!     ");
        Console.WriteLine("-                                       -");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("-                                       -");
        Console.WriteLine("     1.) New Entry                       ");
        Console.WriteLine("-                                       -");
        Console.WriteLine("     2.) Display Journal                 ");
        Console.WriteLine("-                                       -");
        Console.WriteLine("     3.) Save to file                    ");
        Console.WriteLine("-                                       -");
        Console.WriteLine("     4.) Load file                       ");
        Console.WriteLine("-                                       -");
        Console.WriteLine("     5.) Quit                            ");
        Console.WriteLine("-                                       -");
        Console.WriteLine("-----------------------------------------");

        Console.Write("What would you like to do? (Enter 1-5) ");
        // string options = Console.ReadLine();
        int option = int.Parse(Console.ReadLine());


        Journal journal = new Journal();
        // Entry anEntry = new Entry();
        while (option != 5)
        {
            
            if (option == 1)
            {
                journal.AddEntry();
                // string _date = DateTime.Now.ToString("MM/dd/yyyy");
                // string prompt = new PromptGenerator.GetRandomPrompt();
                
                // Entry entry = new AddEntry();
                // // Entry anEntry = new Entry();
                // entry._date = _date;
                // entry._promptText = prompt;
                // Console.WriteLine($"{prompt}");
                // Console.Write("- - -> ")    
                // string user = Console.ReadLine();
                // entry._entryText = userEntry;         
                // journal._entries.Add(entry);
                // journal.AddEntry();
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                journal.SaveToFile();
            }
            else if (option == 4)
            {
                journal.LoadFromFile();
            }
            else 
            {
                Console.WriteLine("Have a good day!");
            }
        }

        

        // Jounal theJournal = new Journal();
        // Entry anEntry = new Entry();
        // anEntry.Display();

        // PromptGenerator aprompt = new PromptGenerator
  
    }
}

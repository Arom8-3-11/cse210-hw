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
        string options = Console.ReadLine();
        int option = int.Parse(options);


        Journal ajournal = new Journal();
        // Entry anEntry = new Entry();

        if (option = 1)
        {
            Entry anEntry = new Entry();
            ajournal.AddEntry(anEntry);
        }
        else if (option = 2)
        {
            ajournal.DisplayAll();
        }
        else if (option = 3)
        {
            
            ajournal.LoadFromFile();
        }
        else if (option = 4)
        {
            ajournal.SaveToFile();
        }
        else 
        {
            Console.WriteLine("Have a good day!");
        }


        

        // Jounal theJournal = new Journal();
        // Entry anEntry = new Entry();
        // anEntry.Display();

        // PromptGenerator aprompt = new PromptGenerator
  
    }
}
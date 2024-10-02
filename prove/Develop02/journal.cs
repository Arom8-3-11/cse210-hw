using System;
using System.IO;
public class Journal 

{

    public List<Entry> _entries;//do not delete or change
    public PromptGenerator promptGenerator;




    public void AddEntry(Entry newEntry)
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine($"{date}, {prompt}");
        Console.Write("> ");
        string newEntry = Console.ReadLine();
        // return entryText;


    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        file = "journal.txt";
        try 
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry}");
                }

            }
            Console.WriteLine($"Entry saved...");

        }
        // Console.WriteLine($"Entry saved...");
        catch (Exception e) 
        {
            Console.WriteLine($"Error saving to {file}: {e. Message}");
        }
    }

    public void LoadFromFile()
    {
        string file = "journal.txt";
        try 
        {
            file = "journal.txt";
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string prompt = parts[1];
                string savedEntry = parts[2];
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading from {file}: {e. Message}");
        }
    }

}






















//     // string filename = "journal.txt";

//     // public List<Entry> _entries;
//     // entries = new List<Entry>();

//     // public PromptGenerator promptGenerator;

//     //initialize list of entries
//     // string entries = new List<Entry>();
//         // Initializes the prompt generator
//     // string _promptGenerator = new PromptGenerator(_prompts);
    

//     //Adds a new entry to the journal from user input
//     public static void AddEntry(Entry newEntry) 
//     {
//         // public string _prompts = PromptGenerator.GetRandomPrompt();
        
//         // public string _date = DateTime.Now.ToString("MM/dd/yyyy");

//         // Console.WriteLine($"Prompt: {_prompts}");

//         // Console.Write("- - - > ");
//         // public string _entryText = Console.ReadLine();




//         string _date = DateTime.Now.ToString("MM/dd/yyyy");
//         string prompt = new PromptGenerator.GetRandomPrompt();
//         Journal journal = new Journal();

//         Entry entry = new Entry();
//         // Entry anEntry = new Entry();
//         entry._date = _date;
//         entry._promptText = prompt;
//         Console.WriteLine($"{prompt}");
//         Console.Write("- - -> ");  
//         string user = Console.ReadLine();
//         newEntry._entryText = user;         
//         Entry._entries.Add(newEntry);
//     }

//     //Displays data input this session
//     public void DisplayAll() 
//     {
//         foreach (Entry entry in _entries) 
//         {
//             entry.Display();
//         }
//     }

//     //Saves Entries to a file named by the user
//     public void SaveToFile(string filename) 
//     {
//         // Console.Write("Enter the file you want to load from: ");
//         // string filename = Console.readline();
//         string filename = "journal.txt";

        
//         StreamWriter outputFile = new StreamWriter(filename); 
//         Console.WriteLine($"Journal entries saved to {filename}");

//         {
//             foreach (Entry entry in entries) 
//             {
//                 outputFile.WriteLine($"{date} | {entry}");
//             }
//         }
//     }

//     //Loads Entries from a file
//     public void LoadFromFile(string filename) 
//     {
//         // Console.Write("Enter the file you want to load from: ");
//         // string filename = Console.readline();
//         List<Entry> journal = new List<Entry>();
//         string filename = "journal.txt";

//         using (StreamReader outputFile = new StreamReader(filename)) //helps with reading from a file
//         {
//             while (!reader.EndOfStream) // gets value that indicates whether current stream position is at end of stream
//             {
//                 string dates = reader.ReadLine();
//                 string content = reader.ReadLine();
//                 Entry entry = new Entry(dates, content);
//                 entries.Add(entry);
//             }
//         } 
//         return journal;
//     }
// }















// string filename = "journal.txt";
//         string[] lines = System.Io.File.ReadAllLines(filename);

//         foreach (string line in lines) 
//         {
//             string[] parts = line.Split("|");

//             string date =parts[0];
//             string Text =parts[1];
//             string entryText =parts[2];
//         }















// public class Journal
// {
//     public List<Entry> _entries;
//     public PromptGenerator promptGenerator;







//     // add entry
//     public void AddEntry(Entry newEntry)
//     {
//         // string prompt = promptGenerator.GenerateRandomPrompt(); //
//         // Console.Write("Pleas enter the date: "); //

//         // DateTime theCurrentTime = DateTime.Now;
//         // public string date = theCurrentTime.ToShortDateString();
//         // string date = Console.ReadLine(); //

//         // Console.WriteLine(GetRandomPrompt()); //
//         // string content = Console.ReadLine(); //

//         List<Entry> addEntry =LoadFromFile("journal.txt");
//         foreach (Entry entry in addEntry)
//         {
//             Console.WriteLine(entry);
//         }






//     }


//     // display all entries
//     public void DisplayAll() // needs to iterate through each entry
//     {
//         foreach (Entry entry in _entries)
//         {
//             Console.WriteLine(entry);

//         }
//     }


//     // save to file
//     public void SaveToFile(string filename)
//     {
//         // Console.Write("Please enter the filename you want to save to: ");
//         Console.WriteLine("Saving to file...");


//         string filename = "journal.txt";

//         using(StreamWriter outputFile = new StreamWriter(filename))
//         {
//             foreach (Entry entry in _entries)
//             {
//                 outputFile.WriteLine(entry);
//             }
//         }

//         SaveToFile(_entries);
//         // try 
//         // {

//         // }

//     }


//     // load from a file
//     public void LoadFromFile(string filename)
//     {
//         Console.WriteLine("Loading from File...");
//         // Console.Write("Please enter the file you would like to load from: ");
//     // public List<Entry> _entries;
//         List<Entry> entries = new list<Entry>();
//         string filename = "journal.txt";

//         return entries;
//     }








// // using System;

// public class Journal 

// {
//     // string filename = "journal.txt";

//     public List <Entry> entries;
//     public PromptGenerator promptGenerator;

//         //Constructor initializes and empty list of entries
//         public Journal() 
//         {
//             entries = new List<Entry>();
//             //Initializes the prompt generator
//             promptGenerator = new PromptGenerator();
//         }

//         //Adds a new entry to the journal from user input
//         public void AddEntry(Entry newEntry) 
//         {
//             // string prompt = promptGenerator.GetRandomPrompt();
            
//             // string date = DateTime.Now.ToString("MM/dd/yyyy");

//             // Console.WriteLine($"Prompt: {prompt}");

//             // Console.Write("- - - ");
//             // string content = Console.ReadLine();
//         }

//         //Displays data input this session
//         public void DisplayAll() 
//         {
//             // foreach (Entry entry in entries) 
//             // {
//             //     entry.Display();
//             // }
//         }

//         //Saves Entries to a file named by the user
//         public static void SaveToFile(string filename) 
//         {
//             // string filename = "journal.txt";
            
//             // using (StreamWriter writer = new StreamWriter(filename)) 
//             // Console.WriteLine($"Journal entries saved to {filename}");

//             // {
//             //     foreach (Entry entry in entries) 
//             //     {
//             //         writer.WriteLine($"{entry.DateCreated}\n{entry.Content}");
//             //     }
//             // }
//         }

//         //Loads Entries from a file
//         public void LoadFromFile(string filename) 
//         {
//             // string filename = "journal.txt";

//             // using (StreamReader reader = new StreamReader(filename)) //helps with reading from a file
//             // {
//             //     while (!reader.EndOfStream) // gets value that indicates whether current stream position is at end of stream
//             //     {
//             //         string dates = reader.ReadLine();
//             //         string content = reader.ReadLine();
//             //         Entry entry = new Entry(dates, content);
//             //         _entries.Add(entry);
//             //     }
//             // } 
//         }
//     }
// }

public class Journal 

{
    // string filename = "journal.txt";

    public List <Entry> _entries;
    // entries = new List<Entry>();

    public PromptGenerator promptGenerator;

    //initialize list of entries
    string entries = new List<Entry>();
        // Initializes the prompt generator
    string _promptGenerator = new PromptGenerator(_prompts);
    

    //Adds a new entry to the journal from user input
    public void AddEntry(Entry newEntry) 
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        
        string date = DateTime.Now.ToString("MM/dd/yyyy");

        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("- - - > ");
        string content = Console.ReadLine();
    }

    //Displays data input this session
    public void DisplayAll() 
    {
        foreach (Entry entry in entries) 
        {
            entry.Display();
        }
    }

    //Saves Entries to a file named by the user
    public void SaveToFile(string filename) 
    {
        string filename = "journal.txt";
        
        StreamWriter outputFile = new StreamWriter(filename); 
        Console.WriteLine($"Journal entries saved to {filename}");

        {
            foreach (Entry entry in entries) 
            {
                outputFile.WriteLine($"{date} | {entry}");
            }
        }
    }

    //Loads Entries from a file
    public void LoadFromFile(string filename) 
    {
        string filename = "journal.txt";

        using (StreamReader outputFile = new StreamReader(filename)) //helps with reading from a file
        {
            while (!reader.EndOfStream) // gets value that indicates whether current stream position is at end of stream
            {
                string dates = reader.ReadLine();
                string content = reader.ReadLine();
                Entry entry = new Entry(dates, content);
                entries.Add(entry);
            }
        } 
    }
}































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

public class Entry
{

    public string _date;
    // _date = date
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date} | {_promptText} | {_entryText}");
    }




}
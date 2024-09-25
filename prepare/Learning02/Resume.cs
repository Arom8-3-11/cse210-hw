using System;
// using "public" as a modifier means that instead of being visible internaly  the document becomes visible anywhere
public class Resume
{
    public string _name;

    public void Display() //this won't display anything yet
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)//kind of like for loop in python
        {
            job.Display();
        }
    }
}
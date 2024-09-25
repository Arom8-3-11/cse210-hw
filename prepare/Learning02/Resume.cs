using System;
// using "public" as a modifier means that instead of being visible internaly  the document becomes visible anywhere
public class Resume
{
    public string _name;
    
    //Hint: data type for this should be List<Job> and is probably easiest to initialize this to a new list right when you declare it
    public List<Job> _jobs = new List<Job>();

    public void Display() //this won't display anything yet
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)//kind of like for loop in python
        {
            job.Display();
        }

        //had to double check my own with sample due to error code saying that there were no errors.
        //I just didn't write the list line properly.
    }
}
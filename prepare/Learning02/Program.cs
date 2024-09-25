using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Crew Trainer";
        job1._company = "Subway";
        job1._startYear = 2017;
        job1._endYear = 2019;

        //create second job. these two sets are what is going to be somehow displayed using the job.cs file
        Job job2 = new Job();
        job2._jobTitle = "Cashier/Department Lead";
        job2._company = "Hobby Lobby";
        job2._startYear = 2021;
        job2._endYear = 2024;


        // note to self for difference with/without '_' it is a common name convetion for differentiating private vs public properties
        // this is actually a good way for me to remember since sometimes using too many variables can get confusing with more than one doc.


        Resume myResume = new Resume();
        myResume._name = "Audrey Romrell";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



        // If I have anything that says "sample" this is me trying to figure out what I did wrong
        // I had an error message popping up and then it kept on saying that there was nothing to fix. figured out it was part of the display program on the resume page.




        // // sample
        // Job job1 = new Job();
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 2019;
        // job1._endYear = 2022;

        // Job job2 = new Job();
        // job2._jobTitle = "Manager";
        // job2._company = "Apple";
        // job2._startYear = 2022;
        // job2._endYear = 2023;

        // Resume myResume = new Resume();
        // myResume._name = "Allison Rose";

        // myResume._jobs.Add(job1);
        // myResume._jobs.Add(job2);

        // myResume.Display();
    }
}
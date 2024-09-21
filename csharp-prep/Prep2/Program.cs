using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        Console.Write("What is your grade (percent)? ");
        string percent = Console.ReadLine(); //this will make a variable string from the previous console.write statement
        int number = int.Parse(percent); //this will help convert a string into an integer

        string letter = " ";


        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // string symbol ="";

        // if (number > 96, 86, 76, 66)
        // {
        //     symbol ="+";
        // }
        // else if (number < 93, 83, 73, 63)
        Console.WriteLine($"You grade is: {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You passed the class!");
        }

        else
        {
            Console.WriteLine("Keep working on it!");
        }





    }
}
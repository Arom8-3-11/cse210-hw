using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("What is the magic number? ");

        Random number = new Random();
        int magicnum = number.Next(1, 101);

        int guess = -1;
        int tries =0;

        // Console.Write("What is your guess? ");
        // string guessnumber = Console.ReadLine();
        // int guess = int.Parse(guessnumber);

        while (guess != magicnum)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            tries += 1; //stretch
            if (magicnum > guess)
            {
                Console.WriteLine("higher");
            }

            else if (magicnum < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You are correct!");
                Console.WriteLine($"You made {tries} guesses"); //stretch
            }
        }
    }
}
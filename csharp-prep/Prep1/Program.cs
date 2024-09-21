using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!"); //in a lot of ways I can see how similar each of these parts are similar to python

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string second = Console.ReadLine();

        Console.WriteLine($"Your name is {second}, {first} {second}. ");
    }
}
using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts; //allows creation of a list to iterate through
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something that I would like to do in the future?",
        "What is something that I need to vent about?"
    };










    // public PromptGenerator()
    // {
    //     _prompts = new List<string>
    //     {
    //         "Who was the most interesting person I interacted with today?",
    //         "What was the best part of my day?",
    //         "How did I see the hand of the Lord in my life today?",
    //         "What was the strongest emotion I felt today?",
    //         "If I had one thing I could do over today, what would it be?",
    //         "What is something that I would like to do in the future?",
    //         "What is something that I need to vent about?"
    //     };
    // }
     public string GetRandomPrompt()
    {
        // Random random = new Random();
        // int index = random.Next(_prompts);
        // return _prompts[index];
        return _prompts;
    }

}
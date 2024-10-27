using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(4);
        Console.WriteLine("Start listing! (Press Enter after each entry.)");
        List<string> entries = GetListFromUser();
        _count = entries.Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrEmpty(entry))
            {
                entries.Add(entry);
            }
        }
        return entries;
    }
}
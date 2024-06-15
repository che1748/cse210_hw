using System;

public class ListingActivity : Activity
{
    private List<string> _prompt = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "listing";
        _summary = "This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.";
        _duration = 0;
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompt.Count);
        return _prompt[index];
    }

    public void DisplayInstruction()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You may begin in:");
        DisplayTimer(5);

        int i =0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            i++;
        }
        Console.WriteLine($"You listed {i} items!");
        

    }
}
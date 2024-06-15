using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompt = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflection = new List<string>()
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        _name = "reflection";
        _summary = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompt.Count);
        return _prompt[index];
    }

    public string GetRandomReflection()
    {
        Random rand = new Random();
        int index = rand.Next(_reflection.Count);
        return _reflection[index];       
    }

    public void DisplayInstruction()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"---{GetRandomPrompt()}---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        if (input != "whatever")
        {
            Console.WriteLine("\nNow ponder each of the following questions as they related to this experience.");
            Console.WriteLine("You may begin in:");
            DisplayTimer(5);
            Console.Clear();

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine($"> {GetRandomReflection()}");
                DisplaySpinner(10);
            }
        
            
        }

    }
}   
using System;

public class Prompt
{
    private List<string> _prompts = new List<string>
    {
        // suggested prompts
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",

        // other prompts
        "How effective do you think you made use of of your time today? Why?",
        "What is something you wish to have done today?",
        "What or who are you grateful for today?",
        "What is the best food you had today?",
        "What is something you did today that you are proud of?",
        "What is the most important thing you leanred today?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
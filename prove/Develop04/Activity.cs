using System;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _name;
    protected string _summary;
    protected int _duration;



    public void SetDuration(int duration)  {_duration = duration;}


    public void DisplaySpinner(int time)
    {
        List<string> animationString = new List<string>()
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(time);
        int i =0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count)
            {
                i=0;
            }
        }     
    }

    public void DisplayTimer(int time)
    {
        for (int i = time; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} activity \n{_summary}\n");
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!\n");
        DisplaySpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} activity.\n");
        DisplaySpinner(5);
        Console.Clear();

    }

    

}
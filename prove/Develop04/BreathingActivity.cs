using System;

public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "breathing";
        _summary = "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.";
        _duration = 0;
    }


    
    public void DisplayInstruction()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(" ");
            Console.Write("Breath in...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breath out...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
        }
    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Andrew", "chemistry");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Andy", "physics", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Abby","humanity","Why help the poor?");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
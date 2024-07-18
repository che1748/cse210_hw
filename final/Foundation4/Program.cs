using System;

class Program
{
    static void Main(string[] args)
    {
        Running ac1 = new Running("7/17/2024", 30, 5);
        Cycling ac2 = new Cycling("6/5/2024", 55, 7.2);
        Swimming ac3 = new Swimming("1/1/2024", 60, 40);

        List<Activity> activitiyList = new List<Activity>()
        {ac1, ac2, ac3};

        foreach (Activity ac in activitiyList)
        {
            Console.WriteLine(ac.GetSummary());
            Console.WriteLine("\n");
        }
    }
}
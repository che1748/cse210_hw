using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> test = new List<string>()
        {
            "apple","bee","cat"
        };

        Console.Write(test[0]);
        Console.WriteLine(test.Count);

        for (int i=0; i<4; i++)
        {
            Console.WriteLine(i);
        }
    }
}
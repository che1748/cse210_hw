using System;
using System.Net;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Random rdm = new Random();
        int magic = rdm.Next(1, 101);

        int guess;
        int i = 0;
        string again = "yes";
        
        while (again == "yes")
        {
            do
            {
                Console.WriteLine("What is the magic number?");
                guess = int.Parse(Console.ReadLine());
                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                i += 1;
            } while (guess != magic);

            Console.WriteLine($"You took {i} time(s) to guess it.");
            Console.WriteLine("Do you want to play again?");
            again = Console.ReadLine();
        }

        




    }
}
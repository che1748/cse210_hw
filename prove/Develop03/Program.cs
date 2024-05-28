using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref_ = new Reference("Ether", "12", "27");
        string scriptureQuote = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        Scripture scrip_ = new Scripture(ref_, scriptureQuote);

        string userInput;
        scrip_.Display();
        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();

            Console.Clear();
            scrip_.HideWords();
            scrip_.Display();

            if (scrip_.IsItCompletelyHidden()) 
            {
                Console.WriteLine("\nCongratulations. You now have memorized the scripture!");
                break;
            }

        } while (userInput != "quit");

        Console.WriteLine("Thank you for using the program!");
    }
}
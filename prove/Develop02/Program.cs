using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        string response = "0";
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write \n2.Display \n3.Load \n4.Save \n5.quit");
            Console.WriteLine("What would you like to do?(put in the number asscoiated with the choice)");
            string userInput = Console.ReadLine();

            // Create a new journal class that stores all the entries
            if (userInput == "1")
            {
                // Use Prompt class to generate prompt
                Prompt prompt = new Prompt();
                string givenPrompt = prompt.GetPrompt();
                // Ask user for response
                Console.WriteLine(givenPrompt);
                string input = Console.ReadLine();
                // Record the date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // Keep all the data into  _entry in the journal class
                
                journal._entry._respondedPropmt.Add(givenPrompt);
                journal._entry._response.Add(input);
                journal._entry._date.Add(dateText);
            }

            else if (userInput == "2")
            {
                journal._entry.DisplayEntry();
            }

            else if (userInput == "3")
            {
                journal._entry._respondedPropmt.Clear();
                journal._entry._response.Clear();
                journal._entry._date.Clear();
                journal._entry = journal.LoadJournal();
            }

            else if (userInput == "4")
            {
                journal.SaveJournal();
            }

            else if (userInput == "5")
            {
                Console.WriteLine("\nThank you for using the Journal App!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        } while (response != "5");


    }
}
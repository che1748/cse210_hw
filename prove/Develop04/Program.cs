using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {string option;
    BreathingActivity Act1 = new BreathingActivity();
    ReflectionActivity Act2 = new ReflectionActivity();
    ListingActivity Act3 = new ListingActivity();
    int breath = 0;
    int reflection = 0;
    int listing = 0;
        do
        {            
            Console.WriteLine("Menu Options:");    
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");    
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");    
            option = Console.ReadLine();
            Console.Clear();

            if (option == "1")
            {
                Act1.DisplayStartingMessage();
                Act1.DisplayInstruction();
                Act1.DisplayEndingMessage();
                breath++;
            }  

            else if (option == "2")
            {
                Act2.DisplayStartingMessage();
                Act2.DisplayInstruction();
                Act2.DisplayEndingMessage();
                reflection++;

            }

            else if (option == "3")
            {
                Act3.DisplayStartingMessage();
                Act3.DisplayInstruction();
                Act3.DisplayEndingMessage();
                listing++;
            }
            else if (option == "4")
            {
                Console.WriteLine("Thank you for using the program!");
                Console.WriteLine("You have completed:");
                Console.WriteLine($"{breath} breathing activities");
                Console.WriteLine($"{reflection} reflection activities");
                Console.WriteLine($"{listing} listing activities");
            }

            else
            {
                Console.WriteLine("Error! Please enter the number associated with the option.");
                Act1.DisplaySpinner(3);
                Console.Clear();
            }
        } while (option != "4");
        

    }
}
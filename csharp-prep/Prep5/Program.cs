using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = ProptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayResult(username, square);



    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }
    
    static string ProptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int FavNum = int.Parse(Console.ReadLine());
        return FavNum;
    }
    static int SquareNumber(int FavNum)
    {
        int square = FavNum * FavNum;
        return square;
    }

    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }

}

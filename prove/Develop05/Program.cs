using System;
using System.Security;
using System.Security.Claims;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {   string choice;
        List<Goal> goalList = new List<Goal>();
        do
        {
            int totalPoints = 0;
            foreach (Goal goal in goalList)
            {
                totalPoints += goal.GetPointsEarned();
            }
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal\n2.Eternal Goal\n3. Checklist Goal");
                string goalChoice = Console.ReadLine();

                if (goalChoice == "1")
                {
                    SimpleGoal goal = new SimpleGoal();
                    goal.RecordEvents();
                    goalList.Add(goal);
                }
                else if (goalChoice == "2")
                {
                    EternalGoal goal = new EternalGoal();
                    goal.RecordEvents();
                    goalList.Add(goal);
                }
                else if (goalChoice == "3")
                {
                    ChecklistGoal goal = new ChecklistGoal();
                    goal.RecordEvents();
                    goalList.Add(goal);
                }

            }

            else if (choice == "2")
            {   
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goalList)
                {
                    int i = goalList.IndexOf(goal);
                    Console.WriteLine($"{i+1}. {goal.GetGoalForDisplay()}");
                }
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine() + ".txt";

                using (StreamWriter ouputFile = new StreamWriter(filename))
                {
                    ouputFile.WriteLine(totalPoints);
                    foreach (Goal goal in goalList)
                    {
                        ouputFile.WriteLine(goal.GetSaveGoalString());
                    }
                }
                goalList.Clear();
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine() + ".txt";
                goalList.Clear();
                {
                    try
                    {
                        string[] lines = System.IO.File.ReadAllLines(filename);
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(",");
                            if (parts[0] == "Simple goal")
                            {
                                bool input;
                                if (parts[4] == "True")
                                {
                                    input = true;
                                }
                                else
                                {
                                    input = false;
                                }
                                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), input, parts[6]);
                                goalList.Add(goal);
                            }
                            else if (parts[0] == "Eternal goal")
                            {
                                EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5]);
                                goalList.Add(goal);
                            }
                            else if (parts[0] == "Checklist goal")
                            {
                                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[7]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4]), parts[8]);
                                goalList.Add(goal);

                            }
                        }       
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("The file is not found in the directory. Please try again.");
                    }
                    
                
                }
              
            }

            else if (choice == "5")
            {
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goalList)
                {
                    int i = goalList.IndexOf(goal);
                    Console.WriteLine($"{i+1}. {goal.GetName()}");
                }
                Console.WriteLine("Which goal did you accomplish?");
                int response = int.Parse(Console.ReadLine());
                goalList[response-1].AddPoints();

            }

            else if (choice == "6")
            {
                Console.WriteLine("Thanks for using the program!");
            }

            else {Console.WriteLine("Please enter a valid option!");}
        } while (choice != "6");

    }
}
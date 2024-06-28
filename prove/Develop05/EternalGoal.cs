using System;
using System.Runtime.InteropServices;

public class EternalGoal : Goal
{

    public EternalGoal() {}

    public EternalGoal(string name, string description, int points, int pointsEarned, string completionTime) : base(name, description, points, pointsEarned, completionTime) {}

    public override void RecordEvents()
    {
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        _name = name;
        _description = description;
        _points = points;
    }

    public override void AddPoints()
    {
        _pointsEarned += _points;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

    }

    public override string GetGoalForDisplay()
    {
        return $"[ ] {_name} ({_description})";
    }

    public override string GetSaveGoalString()
    {return $"Eternal goal,{_name},{_description},{_points},{_pointsEarned},{_completionTime}";}
}
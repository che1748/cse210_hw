using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal()
    {
        _completed = false;
    }

    public SimpleGoal(string name, string description, int points, int pointsEarned, bool completed, string completionTime) : base(name, description, points, pointsEarned, completionTime)
    {
        _completed = completed;
    }


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
        if (_completed)
        {
            Console.WriteLine("You have already completed this goal!");
        }

        else
        {
            _pointsEarned += _points;
            Console.WriteLine($"Congradulations! You have earned {_points} points!");
            _completed = true;
            _completionTime = DateTime.Now.ToString();
        }
    }

    public override string GetGoalForDisplay()
    {
        if (_completed)
        {return $"[X] {_name} ({_description}), completed at {_completionTime}";}
        else
        {return $"[ ] {_name} ({_description})";}
    }

    public override string GetSaveGoalString()
    {return $"Simple goal,{_name},{_description},{_points},{_completed},{_pointsEarned},{_completionTime}";}
}
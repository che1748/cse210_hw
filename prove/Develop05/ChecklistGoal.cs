using System;

public class ChecklistGoal : Goal
{
    private int _times;
    private int _timesCompleted;
    private int _bonus;

    public ChecklistGoal()
    {
        _timesCompleted = 0;
    }

    public ChecklistGoal(String name, string description, int points, int pointsEarned, int times, int timesCompleted, int bonus, string completionTime) : base(name, description, points, pointsEarned, completionTime)
    {
        _times = times;
        _timesCompleted = timesCompleted;
        _bonus = bonus;
    }


    public override void RecordEvents()
    {
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for bonus?");
        int times = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus point for accomlishing that many times?");
        int bonus = int.Parse(Console.ReadLine());
        _name = name;
        _description = description;
        _points = points;
        _times = times;
        _bonus = bonus;
    }

    public override void AddPoints()
    {
        if (_timesCompleted < _times)
        {
            _timesCompleted += 1;
            if (_timesCompleted == _times)
            {
                _pointsEarned += _bonus+_points;
                Console.WriteLine($"You have Earned {_bonus + _points} points.");
                _completionTime = DateTime.Now.ToString();
            }
            else
            {
                _pointsEarned += _points;
                Console.WriteLine($"You have earned {_points} points");
            }
        }
        else {Console.WriteLine("You have already completed this goal!");}
    

    }

    public override string GetGoalForDisplay()
    {
        if (_timesCompleted < _times)
        {return $"[ ] {_name} ({_description}) -- currently completed: {_timesCompleted}/{_times}";}
        else
        {return $"[X] {_name} ({_description}) -- currently completed: {_timesCompleted}/{_times}, Completed at {_completionTime}";}
    }

    public override string GetSaveGoalString()
    {return $"Checklist goal,{_name},{_description},{_points},{_bonus},{_times},{_timesCompleted},{_pointsEarned},{_completionTime}";}

}
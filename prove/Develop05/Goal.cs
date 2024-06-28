using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _pointsEarned;
    protected string _completionTime;
    

    public Goal()
    {
        _pointsEarned = 0;
        _completionTime = "N/A";
    }

    public Goal(string name, string description, int points, int pointsEarned, string completionTime)
    {
        _name = name;
        _description = description;
        _points = points;
        _pointsEarned = pointsEarned;
        _completionTime = completionTime;
    }

    public int GetPointsEarned()
    {
        return _pointsEarned;
    }

    public string GetName()
    {
        return _name;
    }


    public abstract void RecordEvents();
    public abstract void AddPoints();
    public abstract string GetGoalForDisplay();
    public abstract string GetSaveGoalString();
}
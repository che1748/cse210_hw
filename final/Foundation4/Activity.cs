using System;
using System.Data.SqlTypes;

public abstract class Activity
{
    protected string _type;
    private string _date;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }



    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min)-Distance {GetDistance()} km, \nSpeed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

}
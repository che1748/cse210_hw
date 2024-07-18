using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _type = "Swimming";
        _laps = laps;

    }

    public override double GetDistance()
    {
        double distance = 0.05 * _laps;
        return Math.Round(distance,2);
    }

    public override double GetSpeed()
    {
        double speed = 60*GetDistance()/_length;
        return Math.Round(speed,2);
    }

    public override double GetPace()
    {
        double pace = _length/GetDistance();
        return Math.Round(pace,2);
    }
}
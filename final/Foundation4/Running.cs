using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _type = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance,2);
    }

    public override double GetSpeed()
    {
        double speed = 60*_distance / _length;
        return Math.Round(speed,2);
    }

    public override double GetPace()
    {
        double pace = _length/_distance;
        return Math.Round(pace,2);
    }


}
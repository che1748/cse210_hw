using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _type = "Cycling";
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed*_length/60;
        return Math.Round(distance,2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed,2);
    }

    public override double GetPace()
    {
        double pace = 1/(_speed/60);
        return Math.Round(pace,2);
    }
}
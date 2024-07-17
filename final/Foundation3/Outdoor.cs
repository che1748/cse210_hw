using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _type = "Outdoor";
        _weather = weather;
    }

    public override string GetFullDetail()
    {
        return $"{GetStandardDetail()}\nType of event: {_type}\nWeather: {_weather}";
    }
}
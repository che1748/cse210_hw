using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetail()
    {
        return $"{GetStandardDetail()}\nType of event: {_type}\nSpeaker name: {_speaker}\nCapacity: {_capacity}";
    }

}
using System;
using System.Net.Sockets;

public abstract class Event
{
    protected string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetail()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}   Time:{_time}\nAddress: {_address.GetAddressString()}";
    }

    public string GetShortDescription()
    {
        return $"Event type: {_type}    Title:{_title}\nDate: {_date}";
    }

    public abstract string GetFullDetail();
}
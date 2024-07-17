using System;

public class Reception : Event
{
    private string _RVSP;

    public Reception(string title, string description, string date, string time, Address address, string RVSP) : base(title, description, date, time, address)
    {
        _type = "Reception";
        _RVSP = RVSP;
    }

    public override string GetFullDetail()
    {
        return $"{GetStandardDetail()}\nType of event: {_type}\nRSVP email: {_RVSP}";
    }
}
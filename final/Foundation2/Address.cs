using System;
using System.Runtime.CompilerServices;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else if (_country == "US")
        {
            return true;
        }
        else {return false;}
    }

    public string GetAddressString()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}
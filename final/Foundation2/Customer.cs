using System;
using System.Collections.Concurrent;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;   
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddressString();
    }

    public bool LiveInUSA()
    {
        if (_address.IsInUSA())
        {return true;}
        else
        {return false;}
    }
}
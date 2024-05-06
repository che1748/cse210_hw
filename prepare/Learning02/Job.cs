using System;

public class Job
{
    public string _company;
    public string _JobTitle;
    public int _StartYear;
    public int _EndYear;

    public void DisplayInformation()
    {
        Console.WriteLine($"{_JobTitle} ({_company}) {_StartYear}-{_EndYear}");
    }
}
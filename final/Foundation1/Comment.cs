using System;
using System.Runtime.CompilerServices;

public class Comment
{
    private string _person;
    private string _comment;

    public Comment(string person, string comment)
    {
        _person = person;
        _comment = comment;
    }

    public string GetComment()
    {
        return _comment;
    }

    public string GetPerson()
    {
        return _person;
    }
    
}
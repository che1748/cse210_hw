using System;

public class Entry
{
    public List<string> _respondedPropmt;
    public List<string> _response;
    public List<string> _date;

    public void DisplayEntry()
    {
        
        for (int i=0; i<_respondedPropmt.Count;i++)
        {
            Console.WriteLine(_date[i]);
            Console.WriteLine(_respondedPropmt[i]);
            Console.WriteLine(_response[i]);

        }
    }
}


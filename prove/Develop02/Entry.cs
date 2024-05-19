using System;

public class Entry
{
    public List<string> _respondedPropmt = new List<string>();
    public List<string> _response = new List<string>();
    public List<string> _date = new List<string>();
    

    public void DisplayEntry()
    {
        
        for (int i=0; i<(_respondedPropmt.Count);i++)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(_date[i]);
            Console.WriteLine(_respondedPropmt[i]);
            Console.WriteLine(_response[i]);
        }
        Console.WriteLine("--------------------------------");

    }
}


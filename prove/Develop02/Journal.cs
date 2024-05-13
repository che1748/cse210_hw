using System.Diagnostics.Contracts;
using System.IO;


public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public string _filename;


    public void Display()
    {
        foreach (Entry entry in _journal)
        {
            Console.WriteLine(entry);
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string input = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(input);
        Entry loadEntry = new Entry();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            loadEntry._date.Add(parts[0]);
            loadEntry._respondedPropmt.Add(parts[1]);
            loadEntry._response.Add(parts[2]);

        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string input = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(input))
        {
            foreach (Entry entry in _journal)
            {
                outputFile.WriteLine($"{entry._date}, {entry._respondedPropmt}, {entry._response}");
            }
            
        }

    }  
}



using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.IO;


public class Journal
{
    public Entry _entry = new Entry();
    //private Password _password = new Password();


    

    public Entry LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string input = Console.ReadLine();
        Console.WriteLine("What is the password?");
        string password = Console.ReadLine();

        Password database = new Password();
        string[] passwords = System.IO.File.ReadAllLines("password.txt");
        foreach (string line in passwords)
        {
            string[] parts = line.Split(",");
            database._filename.Add(parts[0]);
            database._密码.Add(parts[1]);
        }

        Entry loadEntry = new Entry();
        int index = database._filename.IndexOf(input);
        if (password != database._密码[index])
        {
            Console.Write("Wrong password!");
        }
        else
        {
            string[] lines = System.IO.File.ReadAllLines(input);
            foreach (string line in lines)
            {
                string[] parts = line.Split(";");
                Console.WriteLine(parts);
                loadEntry._date.Add(parts[0]);
                loadEntry._respondedPropmt.Add(parts[1]);
                loadEntry._response.Add(parts[2]);
            }
        }
        return loadEntry;

        
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string input = Console.ReadLine();
        Console.WriteLine("Please set a password:");
        string password = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(input))
        {
            for (int i=0; i< (_entry._respondedPropmt.Count); i++)
            {
                outputFile.WriteLine($"{_entry._date[i]};{_entry._respondedPropmt[i]};{_entry._response[i]}");
            }
        }

    string filePassword = "password.txt";
    string appendText = $"{input},{password}" + Environment.NewLine;
    File.AppendAllText(filePassword, appendText);    
        
      
        
    }  
}



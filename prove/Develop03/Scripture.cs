using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = new List<Word>();

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        string[] scriptureWords = scripture.Split(" ");
        foreach (string word in scriptureWords)
        {
            Word eachWord = new Word(word);
            _scripture.Add(eachWord);
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.ReferenceInString());
        StringBuilder sb = new StringBuilder();
        foreach (Word word in _scripture)
        {
            sb.Append($"{word.GetWord()} ");
        }

        Console.WriteLine(sb);
    }

    public bool IsItCompletelyHidden()
    {
        int hidden = 0;
        foreach (Word word in _scripture)
        {
            if (word.IsHidden())
            {
                hidden += 1;
            }
        }

        if (hidden == _scripture.Count)
        {
            return true;
        }
        else {return false;}
    }

    

    public void HideWords()
    {

        Random rand = new Random();
        
        for (int i=0; i<3; i++)
        {
            bool hidden = true;
            while (hidden)
            {
                int randomIndex = rand.Next(0,_scripture.Count);
                if (_scripture[randomIndex].IsHidden() == false)
                {
                    _scripture[randomIndex].Hide();
                    hidden = false;
                }
            }
            if (IsItCompletelyHidden()) {break;}
        }
        
    }
    
}
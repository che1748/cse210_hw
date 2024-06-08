using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _word.Length; i++)
            {
                sb.Append("_");
            }
        return sb.ToString();

        }
        else {return _word;}
    }

}
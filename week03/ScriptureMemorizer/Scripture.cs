using System;
public class Scripture
{
    private string _reference;

    public string _Reference
    {
        get
        {
            return _reference;
        }
        set
        {
            _reference = value;
        }
    }

    public void GetReference()
    {
        string word = _Reference;
        Console.Write(word);
    }
    private List<Word> _words = new List<Word>();

    public List<Word> _Words
    {
        get
        {
            return _words;
        }
        set
        {
            _words = value;
        }
    }

    public void Display()
    {
        foreach(Word word in _Words)
        {
            word.GetDisplay();
        }
    }
}
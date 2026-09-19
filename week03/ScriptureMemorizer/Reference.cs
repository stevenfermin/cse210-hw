using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public string _Book
    {
        get
        {
            return _book;
        }
        set
        {
            _book = value;
        }
    }
    public int _Chapter
    {
        get
        {
            return _chapter;
        }
        set
        {
            _chapter = value;
        }
    }
    public int _Verse
    {
        get
        {
            return _verse;
        }
        set
        {
            _verse = value;
        }
    }
    public int _EndVerse
    {
        get
        {
            return _endVerse;
        }
        set
        {
            _endVerse = value;
        }
    }

    public Reference()
    {
    }
    public Reference(string book, int chapter, int verse)
    {
        _Book = book;
        _Chapter = chapter;
        _Verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _Book = book;
        _Chapter = chapter;
        _Verse = verse;
        _EndVerse = endVerse;
    }

    public string Display()
    {
        string _display = $"{_Book} {_Chapter}:{_Verse}-{_EndVerse} ";
        return _display;
    }
}
using System;

public class reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
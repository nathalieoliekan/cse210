using System;

class Reference
{
    // Define private variables in Reference Class
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; // set default value for endVerse if none given
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0) // if no endverse, only display book, chapter, and verse
        {
            string text = $"{_book} {_chapter}:{_verse}";
            return text;
        }
            
        else // if there is an endverse, display book, chapter, verse, and endverse
        {
            string text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return text;
        }
    }
}
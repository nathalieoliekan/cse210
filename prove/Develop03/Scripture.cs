using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _randomGenerator = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words_string = text.Split(' ');
        foreach (string word in words_string)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _randomGenerator.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string display_text = "";
        foreach (var word in _words)
        {
            display_text += $"{word.GetDisplayText()} ";
        }
        return display_text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
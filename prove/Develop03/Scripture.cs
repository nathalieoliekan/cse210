using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words_string = text.Split(new char[] { ' ' });
        foreach (string word in words_string)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random randomGenerator = new Random();
            int length = _words.Count;
            int index = randomGenerator.Next(1, length);
            object word_to_hide = _words.ElementAt(index);
            word_to_hide.Hide();
        }
    }

    public string GetDisplayText()
    {
       string display_text = "";
       foreach (string word_obj in _words)
       {
        display_text = $"{display_text} {word_obj}";
       }
       return display_text;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true; //  assume that all words are hidden
        foreach (string word_obj in _words)
        {
            bool isHidden = word_obj.isHidden();
            if (isHidden == false)
            {
                allHidden = false; // if any word in _words is not hidden, allHidden is also false
            }
        }
        return allHidden;
    }
}
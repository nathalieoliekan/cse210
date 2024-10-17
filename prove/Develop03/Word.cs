using System;
using System.Diagnostics.Tracing;

class Word
{
    private string _text;
    private bool _isHidden;

    private string _text2 = "";

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        int count = _text.Length;
        for (int i = 0; i < count; i ++)
        {
            _text2 = $"{_text2}_";
        }
    }

    public bool IsHidden()
    {
        if(_text2 != "")
        {
            _isHidden = true;
            return _isHidden;
        }
            
        else{
            _isHidden = false;
            return _isHidden; 
        }
        
    }

    public string GetDisplayText()
    {
        if(_text2 == "")
        {
            string display_text = _text;
            return display_text;
        }
        else
        {
            string display_text = _text2;
            return display_text;
        }
    }
}
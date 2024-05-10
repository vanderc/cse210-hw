using System;

class Word
{
    public bool _show = true;
    public string _text;

    public Word(string word)
    {
        _text = word;
    }

    public void Hide()
    {
        _text = "___";
        _show = false;
    }
}
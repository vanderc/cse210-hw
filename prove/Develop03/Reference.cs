using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verse2;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = verse2;
    }

    public string GetReference()
    {
        if (string.IsNullOrEmpty(_verse2))
        {
            string reference = ($"{_book} {_chapter}: {_verse} - ");
            return reference;
        }
        else
        {
            string reference = ($"{_book} {_chapter}: {_verse} - ");
            return reference;
        }
    }
}
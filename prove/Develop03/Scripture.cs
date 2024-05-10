using System;

class Scripture
{
    public string _reference;

    private string _scripture = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

    private List<Word> _words = new List<Word>();
    private List<Word> _wordsRemaining = new List<Word>();

    public Scripture()
    {
        List<String> toList = _scripture.Split(' ').ToList();

        foreach (String eachWord in toList)
        {
            Word word = new Word(eachWord);
            _words.Add(word);
        }
    }

    public Scripture(string scripture)
    {
        List<String> scripturetoList = scripture.Split(' ').ToList();

        foreach (String currentWord in scripturetoList)
        {
            Word word = new Word(currentWord);
            _words.Add(word);
        }
    }

    public void GetScriptureText()
    {
        Console.Write(_reference);
        foreach(Word word in _words)
        {
            Console.Write(word._text);
            Console.Write(" ");
        }
    }

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }

    public void HideRandomWord(int numberOfWordsToHide)
    {
        Random randomGenerator = new Random();

        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int randomIndex = randomGenerator.Next(0, _words.Count());
            _words[randomIndex].Hide();
        }
    }

    public bool CompletleyHidden()
    {
        foreach (Word wordObject in _words)
        {
            if (wordObject._show == false)
            {
                continue;
            }
        
            if (wordObject._show == true)
            {
                return true;
            }
        }

        return false;
    }
}
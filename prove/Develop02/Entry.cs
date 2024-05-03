using System;

public class Entry
{
    public string _journalEntry;
    public string _prompt;
    public string _promptType;

    static DateTime dateNow = DateTime.Now;
    public string _date = dateNow.ToShortDateString();



    public string FormatEntry()
    {
        return $"Date: {_date} - Prompt: {_prompt} \n{_journalEntry}";
    }
}
using System;
using System.IO;

public class Journal
{
    public List<String> _entries = new List<string>();
    public string _filename;



    public void DisplayEntry()
    {
        foreach (string log in _entries)
        {
            Console.WriteLine($"{log}\n");
        }
    }

    public void SaveJournalFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach(string log in _entries)
            {
                outputFile.WriteLine($"{log}");
            }
        }
    }

    public void LoadJournalFile()
    {
        string fileContent = System.IO.File.ReadAllText(_filename);

        string[] parts = fileContent.Split("");
        foreach (string part in parts)
        {
            if (!string.IsNullOrWhiteSpace(part))
            {
                _entries.Add(part.Trim());
            }
        }
    }
}
using System;
using System.IO;

public class PromptGenerator
{
    public List<string> _shortPrompts = new List<string>
    {
        "What is something that you are going to do tomorrow?",
        "What emotion did you feel most today?",
        "Who did you talk most with today?",
        "What are you going to eat for dinner?"
    };

    public List<string> _regularPrompts = new List<string>
    {
        "If you could change one thing about today what would it be?",
        "What superhero power would you choose and why?",
        "What miracle did you witness recently?",
        "What was the last act of service that you did?"
    };

    public Random random = new Random();

    public string GenerateRegularPrompt()
    {
        int randomIndex = random.Next(_regularPrompts.Count);
        return _regularPrompts[randomIndex];
    }

    public string GenerateShortPrompt()
    {
        int randomIndex = random.Next(_shortPrompts.Count);
        return _shortPrompts[randomIndex];
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "1 Nephi";
        string chapter = "3";
        string verse = "7";
        string verse2 =""; // If you have a second verse

        string userInput = "";

        Scripture scripture = new Scripture();

        Reference reference = new Reference(book, chapter, verse, verse2);

        scripture._reference = reference.GetReference();

        while(scripture.CompletleyHidden() && userInput != "quit")
        {
            scripture.GetScriptureText();
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue or type 'quit' to end: ");
            userInput = Console.ReadLine();
            Console.Clear();
            scripture.HideRandomWord(6);
        }
    }
}
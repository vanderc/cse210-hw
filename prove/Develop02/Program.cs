using System;
using System.ComponentModel.Design;
using System.IO.Enumeration;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program.");

        Journal journal = new Journal();

        int choice;

        do
        {
            Console.WriteLine("\nPlease select one of the following options: ");
            Console.WriteLine("1. Write.");
            Console.WriteLine("2. Display.");
            Console.WriteLine("3. Load.");
            Console.WriteLine("4. Save.");
            Console.WriteLine("5. Quit.");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            

            if (choice == 1)
            {
                Entry entry = new Entry();
                PromptGenerator prompt = new PromptGenerator();

                Console.WriteLine("\nChoose a type of prompt:");
                Console.WriteLine("1. Short Response \n2. Regular");
                Console.Write("> ");
                int option = int.Parse(Console.ReadLine());
                //I made it so there is one option for a quick entry and one for a longer entry.
                if (option == 1)
                {
                    entry._promptType = "Short Response";
                    entry._prompt = prompt.GenerateShortPrompt();

                    Console.WriteLine(entry._prompt);
                }
                else if (option == 2)
                {
                    entry._promptType = "Regular";
                    entry._prompt = prompt.GenerateRegularPrompt();

                    Console.WriteLine(entry._prompt);
                }
                Console.Write("> ");
                entry._journalEntry = Console.ReadLine();

                string formattedEntry = entry.FormatEntry();
                journal._entries.Add(formattedEntry);
            }

            else if (choice == 2)
            {
                journal.DisplayEntry();
            }

            else if (choice == 3)
            {
                journal._entries.Clear();

                Console.Write("What is the file name?\n");
                Console.Write("> ");
                journal._filename = Console.ReadLine();

                journal.LoadJournalFile();
            }

            else if (choice == 4)
            {
                Console.Write("What is the file name?\n");
                Console.Write("> ");
                journal._filename = Console.ReadLine();

                journal.SaveJournalFile();
            }

            else if (choice == 5)
            {
                Console.WriteLine("Bye.");
            }

            else
            {
                Console.WriteLine("Invalid entry, Please try again with a number between 1-5");
            }
        }
        while(choice != 5);
    }
}
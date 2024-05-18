using System;

class Program
{

    //I added a grateful activity.
    static void Main(string[] args)
    {
        Console.Clear();

        
        string menu = "Menu Options:\n" +
        " 1. Start Breathing Activity\n" +
        " 2. Start Reflecting Activity\n" +
        " 3. Start Listing Activity\n" +
        " 4. Grateful Activity\n" +
        " 5. Quit\n" +
        "Select a choice from the menu: ";

        string choice = "0";
        while (choice != "5")
        {
            Console.Write(menu);
            choice = Console.ReadLine();

            string name = "";
            string description = "";

            if (choice == "1")
            {
                name = "Breathing Activity";
                description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathingActivity = new BreathingActivity(name, description);
                breathingActivity.Run();
            }

            else if (choice == "2")
            {
                name = "Reflection Activity";
                description = "This activity will help reflect on times in your lifewhen you have shown strength and resilience. This will help you recognize your strengths.";
                ReflectingActivity reflectingActivity = new ReflectingActivity(name, description);
                reflectingActivity.Run();
            }

            else if (choice == "3")
            {
                name = "Listing Activity";
                description = "This activity will help you reflect on the good in your life by having you list as many things as you can.";
                ListingActivity listingActivity = new ListingActivity(name, description);
                listingActivity.Run();
            }

            else if (choice == "4")
            {
                name = "Grateful Activity";
                description = "This activity will give you time to ponder on the things in your life.";
                GratefulActivity gratefulActivity = new GratefulActivity(name, description);
                gratefulActivity.Run();
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("That is an invalid choice, Try Again.");
            }
        }
        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("June 5th, 2024", 30, "Running", 2);
        activities.Add(run);

        Cycling cycling = new Cycling("June 6th, 2024", 60, "Cycling", 10);
        activities.Add(cycling);

        Swimming swimming = new Swimming("June 7th, 2024", 45, "Swimming", 20);
        activities.Add(swimming);

        Console.WriteLine("Welcome to the Excercise Tracker.");
        Console.WriteLine("Your activities so far:");
        
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
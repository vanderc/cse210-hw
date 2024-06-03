using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lectures lecture = new Lectures("Lecture", "How to be successful in your workplace.", "Come and hear from an expert on how to work efficiently in your career.", "September 19th, 2024", "4:00PM", "2455 S 78th St, Tacoma, WA 98409", "John Doe", 150);
        events.Add(lecture);

        Console.WriteLine(lecture.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());

        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("OutdoorGathering", "Picnic & games", "Bring a your own lunch and picnic blanket and play games together.", "September 20th, 2024", "1:00PM", "501 S I St, Tacoma, WA 98405");
        events.Add(lecture);

        Console.WriteLine(outdoorGatherings.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGatherings.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGatherings.GetFullDetails());

        Receptions receptions = new Receptions("Receptions", "Wedding Reception", "Come celebrate the marriage of John and Jane.", "September 21st, 2024", "6:00PM", "1102 S Pearl St, Tacoma, WA 98465");
        events.Add(lecture);

        Console.WriteLine(receptions.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(receptions.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptions.GetFullDetails());
    }
}
public class GratefulActivity : Activity
{
    public GratefulActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        GetTimeDuration();
        Console.Clear();
        Console.WriteLine("Take a moment to ponder about what things in your life that you are grateful for.");
        Console.Write("You may start in: ");
        ShowCountDown(5);
        Console.Write("\n");
        Console.WriteLine("Things I am grateful for: ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeDuration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }

        Console.WriteLine("\nThanks for participating and thinking about all the blessings that you have.");
        ShowSpinner(5);
        DisplayEndingMessage();
    }

}
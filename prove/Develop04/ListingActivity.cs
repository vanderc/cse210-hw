public class ListingActivity : Activity
{

    public ListingActivity(string name, string description) : base(name, description)
    {

    }
    private List<string> _prompts = new List<string>
    {
        "What are some of your strengths?",
        "What are some activities you have done this week?",
        "Who have you helped recently?"
    };
    private string _randomPrompt = "";

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int promptNum = random.Next(0, _prompts.Count);
        _randomPrompt = _prompts[promptNum];
    }

    public void DisplayRandomPrompt()
    {
        Console.Write(_randomPrompt);
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        GetTimeDuration();
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(5);
        GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the prompt: ");
        Console.Write("---");
        DisplayRandomPrompt();
        Console.Write("---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeDuration);
        int responseCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            responseCount += 1;
        }
        Console.WriteLine($"You listed {responseCount} items.");

        Console.WriteLine();
        DisplayEndingMessage();
    }
    
}
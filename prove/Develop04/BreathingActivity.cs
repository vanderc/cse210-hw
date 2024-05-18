public class BreathingActivity : Activity {

    public BreathingActivity(string name, string description) : base(name, description) {

    }

    public void DisplayBreatheIn()
    {
        Console.Write("Breathe in...");
    }

    public void DisplayBreatheout()
    {
        Console.Write("Breathe out...");
    }

    public void Run() {
        DisplayStartingMessage();
        GetTimeDuration();
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeDuration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            DisplayBreatheIn();
            ShowCountDown(5);
            Console.WriteLine();
            DisplayBreatheout();
            ShowCountDown(5);
            Console.WriteLine();
        } 

        DisplayEndingMessage();
    }
}
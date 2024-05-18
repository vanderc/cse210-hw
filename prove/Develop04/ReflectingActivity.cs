public class ReflectingActivity : Activity
{
   private List<string> _prompts = new List<string>
   {
    "Think of a time when you did something really difficult.",
    "Think of a time you helped someone.",
    "Think of a time you did something selfless."
   };
   private List<string> _questions = new List<string>
   {
    "Have you ever done anything like this before?",
    "How did it start?",
    "How did you feel during it?",
    "What did you learn from this time?"
   };
   private string _randomPrompt = "";
   private string _randomQuestion = "";

   public ReflectingActivity(string name, string description) : base(name,description)
   {

   }

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

   public void SetRandomQuestion()
   {
    Random random = new Random();
    int questionNum = random.Next(0, _questions.Count);
    _randomQuestion = _questions[questionNum];
   }

   public void Run()
   {
    DisplayStartingMessage();
    GetTimeDuration();
    Console.Clear();
    Console.WriteLine("Get ready");
    ShowSpinner(5);
    Console.WriteLine();
    GetRandomPrompt();
    Console.WriteLine("Consider the prompt: ");
    Console.WriteLine();
    Console.Write("---");
    DisplayRandomPrompt();
    Console.WriteLine("---");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_timeDuration);
    while (DateTime.Now < endTime)
    {
        SetRandomQuestion();
        Console.Write($"> {_randomQuestion}");
        ShowSpinner(5);
        Console.WriteLine();
    }
    Console.WriteLine();
    DisplayEndingMessage();

   }
}
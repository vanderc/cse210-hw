public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    
    public Lectures(string eventType, string title, string description, string date, string time, string address, string speaker, int capacity) : base(eventType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLectureInfo()
    {
        string lectureDetails = GetFullDetails();
        return $"{lectureDetails} Speaker: {_speaker}\n Capacity: {_capacity}";
    }
}
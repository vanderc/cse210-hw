public class Receptions : Event
{
    private string _rsvp;

    public Receptions(string eventType, string title, string description, string date, string time, string address) : base(eventType, title, description, date, time, address)
    {
        _rsvp = $"Please RSVP to the reception 3 weeks before {GetDate()}.";
    }

    public string GetReceptionInfo()
    {
        string receptionDetails = GetFullDetails();
        return $"{receptionDetails} {_rsvp}";
    }
}
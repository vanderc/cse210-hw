public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _eventType;

    public Event(string eventType, string description, string date, string time, string address, string title)
    {
        _eventType = eventType;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _title = title;
    }

    public string GetStandardDetails()
    {
        return $"{_title}\n Description: {_description}\n Date: {_date} - Time: {_time}\n Venue Location: {_address}";
    }

    public string GetFullDetails()
    {
        return $"Event Type: {_eventType}\n Description: {_description}\n Date: {_date} - Time: {_time}\n Venue Location: {_address}";
    }

    public string GetShortDetails()
    {
        return $"Event Type: {_eventType}\n {_title}\n Date: {_date}";
    }

    public string GetDate()
    {
        return _date;
    }
}
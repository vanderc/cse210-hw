public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string eventType, string title, string description, string date, string time, string address) : base(eventType, title, description, date, time, address)
    {
        _weather = "**In Case of bad weather the event will be moved to an indoor space**";
    }

    public string GetOutDoorInfo()
    {
        string outdoorDetails = GetFullDetails();
        return $"{outdoorDetails} {_weather}";
    }
}
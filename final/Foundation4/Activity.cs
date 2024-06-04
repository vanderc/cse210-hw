public abstract class Activity
{
    private string _date;
    protected double _time;
    private string _type;
    public Activity(string date, double time, string type)
    {
        _date = date;
        _time = time;
        _type = type;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        double distance = Math.Round(GetDistance(), 1);
        double speed = Math.Round(GetSpeed(), 1);
        double pace = Math.Round(GetPace(), 1);

        return $"{_date}, {_type} ({_time} min) - Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
    }
}
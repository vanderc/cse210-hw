public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double activityTime, string activityType, double laps) : base (date, activityTime, activityType)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _time) * 60;
    }

    public override double GetPace()
    {
        return _time / GetDistance();
    }
}
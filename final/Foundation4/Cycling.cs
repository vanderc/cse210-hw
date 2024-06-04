public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double activityTime, string activityType, double speed) : base (date, activityTime, activityType)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _time / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
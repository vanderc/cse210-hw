public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public void SetIsComplete(bool IsComplete)
    {
        _isComplete = IsComplete;
    }

    public override string GetStringDetails()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[x]";
        }
        return $"{checkbox} {GetShortName()} ({GetDescription()}) ";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints(); 
    }
}
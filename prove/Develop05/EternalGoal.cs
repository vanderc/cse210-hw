public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override string GetStringDetails()
    {
        return $"[ ] {GetShortName()} ({GetDescription()} ";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override int RecordEvent()
    {
        return GetPoints(); 
    }
}
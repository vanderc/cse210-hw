public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus, string shortName, string description, int points) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetStringDetails()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[x]";
        }
        return $"{checkbox} {GetShortName()} ({GetDescription()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target){
            return false;
        }

        return true;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();        
    }
}
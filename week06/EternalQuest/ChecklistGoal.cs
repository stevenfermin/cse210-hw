public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amount = 0) : base(name, description, points)
    {
        _amountCompleted = amount;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted <= _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        
        return _amountCompleted >= _target;
    }

    public int bonus => _bonus;

    public override string GetDetailsString()
    {
        string representation = IsComplete() ? "[X]" : "[ ]";
        return $"{representation} {ShortName} ({Description}) Value: {Points} points -- Progress {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{ShortName},{Description},{Points},{_target},{_bonus},{_amountCompleted}";
    }
}
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targer;
    private int _bonusPoints;

    ChecklistGoal(string name, string description, int points, int target, int bonusPoints) : base(name, description, points)
    {
        _amountCompleted = 0;
        _targer = target;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        // Logic to record the event for a checklist goal
        // For example, increment the amount completed and award points if the target is reached
        _amountCompleted++;
        if (_amountCompleted >= _targer)
        {
            // Award bonus points
        }
    }
    public override bool IsComplete()
    {
        // Logic to determine if the checklist goal is complete
        return _amountCompleted >= _targer;
    }
    public string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed: {_amountCompleted}/{_targer} (Bonus: {_bonusPoints} points)";
    }
    public string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|{_amountCompleted}|{_targer}|{_bonusPoints}";
    }
    
}
public class SimpleGoal : Goal
{
    public bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        // Logic to record the event for a simple goal
        // For example, mark the goal as complete and award points
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        // Logic to determine if the simple goal is complete
        return _isComplete;
    }
    public string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|{_isComplete}";
    }
}
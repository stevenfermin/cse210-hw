public class Goal
{
    private string _goalName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        // Logic to record the event for this goal
    }

    public virtual bool IsComplete()
    {
        // Logic to determine if the goal is complete
        return false; // Placeholder
    }
    public string GetDetailsString()
    {
        return $"{_goalName}: {_description} ({_points} points)";
    }
    public string GetStringRepresentation()
    {
        return $"{_goalName}|{_description}|{_points}";
    }
}
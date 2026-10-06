public class EternalGoal : Goal
{
    EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Logic to record the event for an eternal goal
        // For example, award points without marking the goal as complete
    }
    public override bool IsComplete()
    {
        // Logic to determine if the eternal goal is complete
        // Eternal goals are never complete, so always return false
        return false;
    }
    public string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + "|Eternal";
    }
}
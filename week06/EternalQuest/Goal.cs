using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public int Points => _points;
    public string ShortName => _shortName;
    public string Description => _description;
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string representation = IsComplete() ? "[X]" : "[ ]";
        return $"{representation} {_shortName} ({_description}) Value: {_points} points";
    }
    public abstract string GetStringRepresentation();
}
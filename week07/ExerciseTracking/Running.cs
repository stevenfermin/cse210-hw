public class Running : Exercise
{
    private string _exercise;
    private double _distance;
    private int _Time;
    public Running(int time, double distance, string exercise = "Running") : base(exercise, time)
    {
        _exercise = exercise;
        _Time = time;
        _distance = distance;
    }

    public override string getExerciseInfo()
    {
        double speed = (_distance / _Time) * 60;
        double pace = _Time / _distance;
        string info = $"Distance {_distance} km, Speed {speed} kph, Pace: {pace} min per km";
        return info;
    }
    
}
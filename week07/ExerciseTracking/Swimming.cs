public class Swimming : Exercise
{
    private string _exercise;
    private float _time;
    private float _laps;

    public Swimming(float time, float laps, string exercise = "Swimming") : base(exercise, time)
    {
        _exercise = exercise;
        _time = time;
        _laps = laps;
    }

    public override string getExerciseInfo()
    {
        float distance = _laps * 50 / 1000;
        float speed = (distance / _time) * 60;
        float pace = _time / distance;
        string info = $"Distance {distance}, Speed {speed} kph, Pace {pace} min per km";
        return info;
    }
}
public class Cycling : Exercise
{
    private string _exercise;
    private float _time;
    private float _speed;

    public Cycling(float time, float speed, string exercise = "Cycling") : base(exercise, time)
    {
        _exercise = exercise;
        _time = time;
        _speed = speed;
    }

    public override string getExerciseInfo()
    {
        float distance = (_speed * _time) / 60;
        float pace = _time / distance;
        string info = $"Distance {distance} km, Speed {_speed}, Pace {pace} min per kp";
        return info;
    }
}
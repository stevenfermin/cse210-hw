public abstract class Exercise
{
    private string _date = DateTime.Now.ToString("dd/MMM/yy");
    private string _exercise;
    private float _exerciseTime;
    public Exercise(string exercise, float exerciseTime)
    {
        _exercise = exercise;
        _exerciseTime = exerciseTime;
    }

    public virtual string GetSummary()
    {
        string summary = $"{_date} {_exercise} ({_exerciseTime} min)- {getExerciseInfo()}";
        return summary;
    }

    public abstract string getExerciseInfo();
}
using System;

public class ExeriseManager
{
    private List<Exercise> _exercises = new List<Exercise>();
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");
        Running running1 = new Running(30, 3);

        Cycling cycling1 = new Cycling(30, 15);

        Swimming swimming1 = new Swimming(30, 10);

        ExeriseManager exerciseManager = new ExeriseManager();
        exerciseManager._exercises.Add(running1);
        exerciseManager._exercises.Add(cycling1);
        exerciseManager._exercises.Add(swimming1);

        exerciseManager.loadExercises();
        Console.WriteLine("\nTracking complete!");
        Thread.Sleep(5000);
        
    }
    
    public void loadExercises()
    {
        for (int i = 0; i < _exercises.Count; i++)
        {
            Console.WriteLine($"{_exercises[i].GetSummary()}");
        }
    }


}
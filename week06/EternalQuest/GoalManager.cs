using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;

    private int _totalPoints;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
    }

    GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }
    public void Start(){}

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _goals)
        {
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _goals)
        {
        }
    }

    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal(string name, string description, int points)
    {
        Goal newGoal = new Goal(name, description, points);
        _goals.Add(newGoal);
    }
    public void RecordEvent(string goalName)
    {
        
    }
    public void SaveGoals()
    {
        string _filename = "goals.txt";
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            foreach (Goal goal in _goals)
            {
                
            }
        }
    }
    public void LoadGoals()
    {
        string _filename = "goals.txt";
        if (File.Exists(_filename))
        {
            string[] lines = File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    CreateGoal(name, description, points);
                }
            }
        }
    }
}
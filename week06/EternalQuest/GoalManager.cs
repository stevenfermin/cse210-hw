using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.ComponentModel.Design;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool opencondition = true;
        while (opencondition == true)
        {
            Console.WriteLine($"\nYou have {manager._score} points.\n");
            Console.Write("Menu Options:\n 1. Create a new goal\n 2. List of goals\n 3. Save Goals\n 4. Load goals\n 5. Record Event\n 6. Quit\nSelect a choice from the menu: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    manager.CreateGoal();
                    break;
                case 2:
                    manager.ListGoalNames();
                    break;
                case 3:
                    manager.SaveGoals();
                    break;
                case 4:
                    manager.LoadGoals();
                    break;
                case 5:
                    manager.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Thanks for using the Goal program! Hope to see you soon!!");
                    Thread.Sleep(2000);
                    opencondition = false;
                break;
                default:
                    Console.WriteLine("Option not implemented yet");
                    break;
            }
        }
        
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            // Uses GetDetailsString() inherited from Goal
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        string name = "";
        string description = "";
        int points = 0;

        Console.Write("\nThe types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of goal would you like to create? ");
        int goaloption = int.Parse(Console.ReadLine());
        switch (goaloption)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("what is a brief description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of point to win with this goal? ");
                points = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("what is a brief description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of point to win with this goal? ");
                points = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal =  new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("what is a brief description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of point to win with this goal? ");
                points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be completed for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the amount of bonus points will be earned when completing this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                
                break;
            default:
                Console.WriteLine("This is an invalid option, please try again");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("\nWhich goal did you complete? ");
        int selection = int.Parse(Console.ReadLine());
        if (selection > 0 && selection <= _goals.Count)
        {
            int index = selection -1;
            Goal selectedGoal = _goals[index];

            if (!selectedGoal.IsComplete())
            {
                selectedGoal.RecordEvent();
                int plusPoints = selectedGoal.Points;

                if (selectedGoal is ChecklistGoal checklistgoal && checklistgoal.IsComplete())
                {
                    int plusBonus = checklistgoal.bonus;
                    Console.WriteLine($"Congratulations in succesfully compliting this goal! You got {plusBonus} points of bonus");
                    _score+= plusBonus;
                }
                _score += plusPoints;
                Console.WriteLine($"Congratulations in compliting this goal and earned {selectedGoal.Points} points!!");
            }
            else
            {
                Console.WriteLine("You've already completed this goal");
            }
;
            
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename to save the goals? ");
        string filename = Console.ReadLine();

        using (StreamWriter Writer = new StreamWriter(filename))
        {
            Writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                Writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals Saved");
        Thread.Sleep(2000);
    }

    public void LoadGoals()
    {
        Console.WriteLine("what is the filename to load the goals? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("The file cannot be found :C");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line =  lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(":");
            string goalType = parts[0];
            string[] details = parts[1].Split(',');
            
            if (goalType == "SimpleGoal")
            {
                string name =  details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool isComplete = bool.Parse(details[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name =  details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                EternalGoal eternalGoal = new EternalGoal(name,description,points);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name =  details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                int target = int.Parse(details[3]);
                int bonus = int.Parse(details[4]);
                int amount = int.Parse(details[5]);

                ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,target,bonus,amount);
                _goals.Add(checklistGoal);
            }
        }
    }

}
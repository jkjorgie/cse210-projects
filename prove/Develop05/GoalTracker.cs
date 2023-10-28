using System.IO;
class GoalTracker
{
    List<Goal> _goals;
    public GoalTracker()
    {
        _goals = new List<Goal>();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string descr = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());

        Goal g;
        switch (goalType)
        {
            case "1":
            {
                g = new SimpleGoal(name, descr, points);
                _goals.Add(g);
                break;
            }
            case "2":
            {
                g = new EternalGoal(name, descr, points);
                _goals.Add(g);
                break;
            }
            case "3":
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int bonusCount = int.Parse(Console.ReadLine());
                Console.Write("How many points is the bonus worth? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                g = new ChecklistGoal(name, descr, points, bonusCount, bonusPoints);
                _goals.Add(g);
                break;
            }
        }
    }

    public int GetTotalPoints()
    {
        int totalPoints = 0;
        for (int i = 0; i < _goals.Count; i++)
        {
            totalPoints += _goals[i].GetPoints();
        }

        return totalPoints;
    }

    public void DisplayGoalsAsChecklist()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalAsListString()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename))
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                sw.WriteLine(_goals[i].GetGoalAsSaveString());
            }
        }

        Console.WriteLine($"Goals have been successfully saved to: {filename}");
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the saved goal file? ");
        string filename = Console.ReadLine();

        using (StreamReader sr = new StreamReader(filename))
        {
            string[] lines = sr.ReadToEnd().Split("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                switch (parts[0])
                {
                    case "SimpleGoal":
                    {
                        SimpleGoal g = new SimpleGoal();
                        g.LoadGoalFromString(lines[i]);
                        _goals.Add(g);
                        break;
                    }
                    case "EternalGoal":
                    {
                        EternalGoal eg = new EternalGoal();
                        eg.LoadGoalFromString(lines[i]);
                        _goals.Add(eg);
                        break;
                    }
                    case "ChecklistGoal":
                    {
                        ChecklistGoal cg = new ChecklistGoal();
                        cg.LoadGoalFromString(lines[i]);
                        _goals.Add(cg);
                        break;
                    }
                }
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i].IsComplete())
            {
                Console.WriteLine($"  {i + 1}. --COMPLETED--");
            }
            else
            {
                Console.WriteLine($"  {i + 1}. {_goals[i].GetName()}");
            }
        }
        Console.Write("Which goal did you accomplish? ");
        int resp;
        Goal g;
        do
        {
            resp = int.Parse(Console.ReadLine());

            g = _goals[resp - 1];
            if (!g.IsComplete())
            {
                g.Complete();
                break;
            }
            else
            {
                Console.Write("Goal has already been completed. Please choose another: ");
            }
        } while (true);
        Console.WriteLine($"Congratulations! You have earned {g.GetPoints()} total on this goal!");
        Console.WriteLine($"You now have {this.GetTotalPoints()}.");
    }

    public void CloneGoal()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Which goal do you want to clone? ");
        int response = int.Parse(Console.ReadLine());
        Console.Write("What is the name for the cloned goal? ");
        string name = Console.ReadLine();
        Goal clone = _goals[response - 1].Clone(name);
        _goals.Add(clone);

        Console.WriteLine($"You have successfully cloned [{_goals[response - 1].GetName()}] as [{clone.GetName()}].");
    }
}
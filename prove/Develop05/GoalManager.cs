public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public GoalManager()
    {
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }
    }
    public void LoadGoals(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            _totalPoints = int.Parse(reader.ReadLine());
            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] stringList = line.Split(":");
                string className = stringList[0];
                string content = stringList[1];

                if (className == "SimpleGoal")
                {
                    Goal g = SimpleGoal.LoadString(content);
                    _goals.Add(g);
                }
                else if (className == "EternalGoal")
                {
                    Goal g = EternalGoal.LoadString(content);
                    _goals.Add(g);
                }
                else if (className == "ChecklistGoal")
                {
                    Goal g = ChecklistGoal.LoadString(content);
                    _goals.Add(g);
                }
                else if (className == "TimeGoal")
                {
                    Goal g = TimeGoal.LoadString(content);
                    _goals.Add(g);
                }
                else
                {
                    Console.WriteLine($"Unknown goal type {className}");
                }
            }
        }
    }
    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. [{(goal.IsComplete() ? "X" : " ")}] {goal}");
        }
    }
    public void DisplayGoals()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal}");
        }
    }
    public void RecordGoal(int goalIndex)
    {
        if (_goals[goalIndex].IsComplete())
        {
            Console.WriteLine("The goal is already complete. :)");
            return;
        }
        int points = _goals[goalIndex].RecordEvent();
        _totalPoints += points;
        Console.WriteLine($"Congratulations! You have earned {points} points! ");
        Console.WriteLine($"You now have {_totalPoints} points.");
    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }
}

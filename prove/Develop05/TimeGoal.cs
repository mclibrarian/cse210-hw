public class TimeGoal : Goal
{
    private int _completionPointBonus;
    private int _minutesCount = 0;
    private int _completionThreshold;
    public TimeGoal(string name, string description, int points, int completionPointBonus, int completionThreshold) : base(name, description, points)
    {
        _completionPointBonus = completionPointBonus;
        _completionThreshold = completionThreshold;
    }

    public override string ToString()
    {
        return $"{_name} ({_description}) -- Minutes Completed: {_minutesCount}/{_completionThreshold}";
    }

    public override int RecordEvent()
    {
        Console.Write("How many minutes did you complete? ");
        int response = int.Parse(Console.ReadLine());
        _minutesCount += response;
        if (_minutesCount > _completionThreshold)
        {
            _minutesCount = _completionThreshold;
        }
        if (IsComplete())
        {
            return _points + _completionPointBonus;
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _minutesCount == _completionThreshold;
    }

    public override string SaveString()
    {
        return $"TimeGoal:{_name}|{_description}|{_points}|{_completionPointBonus}|{_completionThreshold}|{_minutesCount}";
    }

    public static Goal LoadString(string line)
    {
        string[] stringList = line.Split("|");
        TimeGoal newGoal = new TimeGoal(stringList[0], stringList[1], int.Parse(stringList[2]), int.Parse(stringList[3]), int.Parse(stringList[4]));
        newGoal._minutesCount = int.Parse(stringList[5]);
        return newGoal;
    }
}
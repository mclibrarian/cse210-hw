public class ChecklistGoal : Goal
{
    private int _completionPointBonus;
    private int _checkedOffCount = 0;
    private int _completionThreshold;
    public ChecklistGoal(string name, string description, int points, int completionPointBonus, int completionThreshold) : base(name, description, points)
    {
        _completionPointBonus = completionPointBonus;
        _completionThreshold = completionThreshold;
    }

    public override string ToString()
    {
        return $"{_name} ({_description}) -- Currently Completed: {_checkedOffCount}/{_completionThreshold}";
    }

    public override int RecordEvent()
    {
        _checkedOffCount += 1;
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
        return _checkedOffCount == _completionThreshold;
    }

    public override string SaveString()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_completionPointBonus}|{_completionThreshold}|{_checkedOffCount}";
    }

    public static Goal LoadString(string line)
    {
        string[] stringList = line.Split("|");
        ChecklistGoal newGoal = new ChecklistGoal(stringList[0], stringList[1], int.Parse(stringList[2]), int.Parse(stringList[3]), int.Parse(stringList[4]));
        newGoal._checkedOffCount = int.Parse(stringList[5]);
        return newGoal;
    }
}
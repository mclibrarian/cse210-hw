public class SimpleGoal : Goal
{
    private bool _completed;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        _completed = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return _completed;
    }

    public override string SaveString()
    {
        return $"SimpleGoal:{_name}|{_description}|{_points}|{_completed}";
    }

    public static Goal LoadString(string line)
    {
        string[] stringList = line.Split("|");
        SimpleGoal newGoal = new SimpleGoal(stringList[0], stringList[1], int.Parse(stringList[2]));
        newGoal._completed = bool.Parse(stringList[3]);
        return newGoal;
    }
}
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveString()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}";
    }

    public static Goal LoadString(string line)
    {
        string[] stringList = line.Split("|");
        return new EternalGoal(stringList[0], stringList[1], int.Parse(stringList[2]));
    }

}
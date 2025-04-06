public abstract class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract string GetName();
    public abstract float CalculateDistance();
    public abstract float CalculateSpeed();
    public abstract float CalculatePace();
    public string GetSummary()
    {
        return $"{_date} {GetName()} ({_duration}) - Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}
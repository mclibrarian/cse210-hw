public class Running : Activity
{
    private float _distance;

    public Running(string date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }
    public override string GetName()
    {
        return "Running";
    }
    public override float CalculateDistance()
    {
        return (_distance);
    }
    public override float CalculateSpeed()
    {
        return ((_distance / _duration) * 60);
    }
    public override float CalculatePace()
    {
        return (_duration / _distance);
    }
}
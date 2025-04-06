public class Swimming : Activity
{
    private float _lapCount;

    public Swimming(string date, int duration, float lapCount) : base(date, duration)
    {
        _lapCount = lapCount;
    }
    public override string GetName()
    {
        return "Swimming";
    }
    public override float CalculateDistance()
    {
        return _lapCount * 50 / 1000 * 0.62f;
    }
    public override float CalculateSpeed()
    {
        return CalculateDistance() / _duration * 60;
    }
    public override float CalculatePace()
    {
        return _duration / _lapCount;
    }
}
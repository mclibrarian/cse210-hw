public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override string GetName()
    {
        return "Cycling";
    }
    public override float CalculateDistance()
    {
        return _speed * _duration;
    }
    public override float CalculateSpeed()
    {
        return _speed;
    }
    public override float CalculatePace()
    {
        return 60 / _speed;
    }
}
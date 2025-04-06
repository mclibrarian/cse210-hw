public class OutdoorGathering : Event
{
    private string _forecast;

    public OutdoorGathering(string name, string description, string date, string time, string forecast, Address address) : base(name, description, date, time, address)
    {
        _forecast = forecast;
    }
    public override string EventType()
    {
        return "Outdoor Gathering";
    }
    public override string FullDetails()
    {
        return StandardDetails() + $" The weather will be {_forecast}.";
    }
}
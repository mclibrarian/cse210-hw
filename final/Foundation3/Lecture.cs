public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string name, string description, string date, string time, string speaker, int capacity, Address address) : base(name, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string EventType()
    {
        return "Lecture";
    }
    public override string FullDetails()
    {
        return StandardDetails() + $" {_speaker} is speaking and there are {_capacity} seats available.";
    }
}
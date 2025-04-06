public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string name, string description, string date, string time, Address address)
    {
        _title = name;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public abstract string EventType();
    public string StandardDetails()
    {
        return $"{_title}, {_description}, is happening on {_date} at {_time} o'clock at {_address}";
    }
    public abstract string FullDetails();
    public string ShortDescription()
    {
        return $"A(n) {EventType()} called {_title} is happening on {_date}!";
    }
}
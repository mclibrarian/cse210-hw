public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string name, string description, string date, string time, string rsvpEmail, Address address) : base(name, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string EventType()
    {
        return "Reception";
    }
    public override string FullDetails()
    {
        return StandardDetails() + $" Please RSVP here: {_rsvpEmail}";
    }
}
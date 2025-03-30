public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsInUs()
    {
        if (_address.IsInUS())
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{_name}\n{_address}";
    }
}
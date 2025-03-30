public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    float total = 0;

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string TotalPrice()
    {
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.IsInUs())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return $"Cost: ${total}";
    }
    public string ReturnPackingLabel()
    {
        string _label = "";
        foreach (Product product in _products)
        {
            _label += product.ToString() + "\n";
        }
        return _label;
    }
    public string ReturnShippingLabel()
    {
        return $"{_customer}\n";
    }
}
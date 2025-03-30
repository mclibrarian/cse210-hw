public class Product
{
    private string _name;
    private int _productId;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _productId = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        return _pricePerUnit * _quantity;
    }
    public override string ToString()
    {
        return $"{_productId} {_name} (Quantity: {_quantity})";
    }
}
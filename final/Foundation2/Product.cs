
public class Product
{
    private string _name = "";
    private string _identification = "";
    private double _itemPrice = 0;
    private int _quantity = 0;
    private double _orderPrice = 0;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _identification = id;
        _itemPrice = price;
        _quantity = quantity;
        _orderPrice = _itemPrice * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductIdentification()
    {
        return _identification;
    }

    public double GetItemPrice()
    {
        return _itemPrice;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetOrderPrice()
    {
        return _orderPrice;
    }
}

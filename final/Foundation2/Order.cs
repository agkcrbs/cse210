
public class Order
{
    private Customer _customerObject;
    private List<Product> _orderProductList = new List<Product>();
    private double _sumPrice;
    private double _shippingRateDomestic = 5.00;
    private double _shippingRateForeign = 35.00;

    public Order(string name, string address, string city, string state, string country)
    {
        _customerObject = new Customer(name, address, city, state, country);
    }

    public void AddToProductList(Product productObject)
    {
        _orderProductList.Add(productObject);
    }

    public void GetSummedPrice()
    {
        _sumPrice = 0;
        foreach (Product product in _orderProductList)
        {
            _sumPrice += product.GetOrderPrice();
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "------\nContents:";
        foreach (Product product in _orderProductList)
        {
            packingLabel += "\n(" + product.GetQuantity() + ") " + product.GetProductName() + " [#" + product.GetProductIdentification() + "]";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "\nShip To:\n" + _customerObject.GetName() + "\n" + _customerObject.GetAddressString() + "\n------\n\n";
        return shippingLabel;
    }

    public string GetTotalPrice()
    {
        GetSummedPrice();
        if (_customerObject.GetIsInUSA())
        {
            return "\nSubtotal:   $" + _sumPrice.ToString("f") + "\nShipping:   $" + _shippingRateDomestic.ToString("f") + "\nTotal Cost: $" + (_sumPrice + _shippingRateDomestic).ToString();
        }
        else
        {
            return "\nSubtotal:   $" + _sumPrice.ToString("f") + "\nShipping:   $" + _shippingRateForeign.ToString("f") + "\nTotal Cost: $" + (_sumPrice + _shippingRateForeign).ToString();
        }
    }
}

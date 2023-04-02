
public class Customer
{
    private string _name = "";
    private Address _addressObject;
    private bool _isInUSA;

    public Customer(string name, string address, string city, string state, string country)
    {
        _name = name;
        _addressObject = new Address(address, city, state, country);
    }

    public void SetIsInUSA()
    {
        _isInUSA = _addressObject.GetIsInUSA();
    }

    public bool GetIsInUSA()
    {
        SetIsInUSA();
        return _isInUSA;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressString()
    {
        return _addressObject.GetAddressString();
    }
}

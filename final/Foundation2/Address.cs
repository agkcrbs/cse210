
public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _country = "";

    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public bool GetIsInUSA()
    {
        if (_country.ToUpper() == "U.S.A." || _country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}  {_country}";
    }
}

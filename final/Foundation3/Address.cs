
public class Address
{
    private string _address = "";

    public Address(string address)
    {
        string[] addressArray = address.Split(".");
        int count = 1;
        foreach (string member in addressArray)
        {
            if (count == 1)
            {
                _address += "    " + member + "\n";
            }
            else
            {
                _address += "             " + member + "\n";
            }
            count ++;
        }
    }

    public string GetAddress()
    {
        return _address;
    }
}

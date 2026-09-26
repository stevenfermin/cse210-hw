public class Address
{
    private Dictionary<string, List<string>> _customersAddress = new Dictionary<string, List<string>>();
    private string _street;
    private string _city;
    private string _country;

    public void setAddress(string name, List<string> address)
    {
        _street = address[0];
        _city = address[1];
        _country = address[2];
        _customersAddress.Add(name, new List<string> {_street, _city, _country });
    }

    public Dictionary<string, List<string>> getAddress()
    {
        return _customersAddress;
    }

    public bool countryCheck(string country)
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
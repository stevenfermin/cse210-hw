public class Customer
{
    List<string> _customers = new List<string>();
    private string _name;

    public void setCustomer(string name)
    {
        _name = name;
        _customers.Add(_name);
    }
    public List<string> getCustomers()
    {
        return _customers;
    }

}
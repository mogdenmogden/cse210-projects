public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name; 
        _address = address;
    }

    public string GetCustomerCountry()
    {
        return _address.GetCountry();
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public string GetShipLabel()
    {
        return _name+"\n"+GetAddress();
    }
}
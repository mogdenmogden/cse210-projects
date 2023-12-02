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

    public bool IsUSA()  //this may be redundant, but the assignment spec stated: "The customer should have a method that can return whether they live in the USA or not."
    {
        if (GetCustomerCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public string GetShipLabel()
    {
        return _name+"\n"+GetAddress();
    }
}
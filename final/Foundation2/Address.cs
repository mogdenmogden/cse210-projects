public class Address
{
    private string _streetAddress, _city, _state, _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
        
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetFullAddress()
    {
        return _streetAddress+"\n"+_city+", "+_state+"\n"+_country;
    }
}
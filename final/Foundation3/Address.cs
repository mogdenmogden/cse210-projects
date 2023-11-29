public class Address
{
    private string _streetAddress, _city, _state, _zip;

    public Address(string street, string city, string state, string zip)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _zip = zip;
        
    }

    public Address()
    {
        Console.Write($"What street is your event on? ");
        _streetAddress = Console.ReadLine();
        Console.Write($"Which city? ");
        _city = Console.ReadLine();
        Console.Write($"Which state? ");
        _state = Console.ReadLine();
        Console.Write($"What is the zip code? ");
        _zip = Console.ReadLine();
    }

    public string GetFullAddress()
    {
        return _streetAddress+" "+_city+", "+_state+" "+_zip;
    }
}
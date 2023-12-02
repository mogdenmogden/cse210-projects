public class Outdoor : Event
{
    private string _weather, _FullMsg;

    public Outdoor(string title, string desc, string date, string time, string weather, Address address) : base(title, desc, date, time, address)
    {
        _weather = weather;
        _type = "OUTDOOR EVENT";
        _address = address.GetFullAddress();
        SetFullMsg();
        SetShortMsg();
    }

    private void SetFullMsg()
    {
        _FullMsg = $"{_type}: {_title} - {_description} \nHeld on {_date} at {_time}. \nLocation: {_address}\nCurrent Weather Forecast: {_weather} ";
    }

    public string GetFullMsg()
    {
        return _FullMsg;
    }

    private void SetShortMsg()
    {
        _ShortMsg = $"{_type}: {_title} on {_date}";
    }
    
    public string GetShortMsg()
    {
        return _ShortMsg;
    }

    
}
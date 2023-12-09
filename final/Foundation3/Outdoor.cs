public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string desc, string date, string time, string weather, Address address) : base(title, desc, date, time, address)
    {
        _weather = weather;
        _address = address.GetFullAddress();
        SetFullMsg();
    }

    private void SetFullMsg()
    {
        _FullMsg = $"{GetType()} Event: {_title} - {_description} \nHeld on {_date} at {_time}. \nLocation: {_address}\nCurrent Weather Forecast: {_weather} ";
    }
}
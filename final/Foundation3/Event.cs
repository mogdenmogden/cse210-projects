public class Event
{
    protected string _title, _description, _date, _time, _type, _address;
    protected string _StandardMsg, _ShortMsg;
    
    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        //_type = "Generic";

        _address = address.GetFullAddress();

        SetStandardMsg();

    }

    protected void SetStandardMsg()
    {
        _StandardMsg = $"Event: {_title} - {_description} \nHeld on {_date} at {_time}. \nLocation: {_address}";
    }

    public string GetStandardMsg()
    {
        return _StandardMsg;
    }


}
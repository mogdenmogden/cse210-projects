public class Reception : Event
{
    private string _email, _FullMsg;

    public Reception(string title, string desc, string date, string time, string email, Address address) : base(title, desc, date, time, address)
    {
        _email = email;
        _type = "Reception";
        _address = address.GetFullAddress();
        SetFullMsg();
        SetShortMsg();
    }

    private void SetFullMsg()
    {
        _FullMsg = $"Your {_type} Event: {_title} - {_description} \nHeld on {_date} at {_time}. \nLocation: {_address}\nRSVP is required via: {_email} ";
    }

    public string GetFullMsg()
    {
        return _FullMsg;
    }

    protected void SetShortMsg()
    {
        _ShortMsg = $"Your {_type} Event: {_title} on {_date}";
    }
     public string GetShortMsg()
    {
        return _ShortMsg;
    }
    
}
public class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, string email, Address address) : base(title, desc, date, time, address)
    {
        _email = email;
        _address = address.GetFullAddress();
        SetFullMsg();
    }

    private void SetFullMsg()
    {
        _FullMsg = $"{GetType()} Event: {_title} - {_description} \nHeld on {_date} at {_time}. \nLocation: {_address}\nRSVP is required via: {_email} ";
    }
}
public class Lecture : Event
{
    private string _speaker, _capacity, _FullMsg;

    public Lecture(string title, string desc, string date, string time, string speaker, string capacity, Address address) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _type = "LECTURE";
        _address = address.GetFullAddress();
        SetFullMsg();
        SetShortMsg();
    }

    private void SetFullMsg()
    {
        _FullMsg = $"{_type}: {_title} - {_description} \nHeld on {_date} at {_time}. \nLocation: {_address}\nSpeaker: {_speaker}\nSeating Capacity: {_capacity}.";
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
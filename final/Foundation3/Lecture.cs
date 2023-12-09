public class Lecture : Event
{
    private string _speaker, _capacity;

    public Lecture(string title, string desc, string date, string time, string speaker, string capacity, Address address) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _address = address.GetFullAddress();
        SetFullMsg();
    }

    private void SetFullMsg()
    {
        _FullMsg = $"{GetType()} Event: {_title} - {_description} \nHeld on {_date} at {_time}. \nLocation: {_address}\nSpeaker: {_speaker}\nSeating Capacity: {_capacity}.";
    }
}
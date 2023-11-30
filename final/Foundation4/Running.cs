public class Running : Activity
{
    public new string _type;

    public Running(string date, double duration, double distance) : base(date, duration, distance)
    {
        _type = "Running";
        _date = date;
        _duration = duration;
        _distance = distance;
        // GetSummary(date,duration,distance);
    }

    public override string GetType()
    {
        return "Running";
    }
}
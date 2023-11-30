public class Cycling : Activity
{
    public new string _type;

    public Cycling(string date, double duration, double distance) : base(date, duration, distance)
    {
        _type = "Cycling";
        _date = date;
        _duration = duration;
        _distance = distance;
        // GetSummary(date,duration,distance);
    }

    public override string GetType()
    {
        return "Cycling";
    }
}
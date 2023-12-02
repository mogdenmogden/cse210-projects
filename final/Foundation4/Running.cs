public class Running : Activity
{
    public Running(string date, double duration, double distance) : base(date, duration, distance)
    {
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    public override string GetType()
    {
        return "Running";
    }

    public override void GetSummary()
    {
        Console.WriteLine($"-- {_date} {GetType()} ({_duration} min) - Distance {GetDistance(_distance).ToString("N2")} km, Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km");
    }
}
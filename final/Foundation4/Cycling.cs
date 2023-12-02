public class Cycling : Activity
{
    public Cycling(string date, double duration, double distance) : base(date, duration, distance)
    {
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    public override string GetType()
    {
        return "Cycling";
    }

    public override void GetSummary()
    {
        Console.WriteLine($"-- {_date} {GetType()} ({_duration} min) - Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km (and Distance was {GetDistance(_distance).ToString("N2")} km)");
    }
}
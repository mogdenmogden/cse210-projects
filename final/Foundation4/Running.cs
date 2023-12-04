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

    // public override void GetSummary()  //I can do it this way, too. Maybe more polymorphic, but also a bit redundant.
    // {
    //     Console.WriteLine($"-- {_date} {GetType()} ({_duration} min) - {GetType()} Distance {GetDistance(_distance).ToString("N2")} km, Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km");
    // }
}
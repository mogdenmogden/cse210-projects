public class Running : Activity
{
    private double _duration;
    private string _date;

    public Running(string date, double duration, double distance) : base()
    {
        _distance = distance;
        _date = date;
        _duration = duration;
    }

    public override void GetSummary()  
    {
        Console.WriteLine($"-- {_date} Running ({_duration} min) - {GetType()} Distance {_distance.ToString("N2")} km, Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km");
    }

    public override string GetDate()
    {
        return _date;
    }
    
    public override double GetDuration()
    {
        return _duration;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}
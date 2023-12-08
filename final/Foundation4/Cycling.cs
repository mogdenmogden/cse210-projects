public class Cycling : Activity
{
    private double _speed,_duration;
    private string _date;
    
    public Cycling(string date, double duration, double speed) : base()
    {
        _speed = speed;
        _date = date;
        _duration = duration;
    }

    public override void GetSummary()  
    {
        Console.WriteLine($"-- {_date} Cycling ({_duration} min) - {GetType()} Distance {GetDistance().ToString("N2")} km, Speed: {GetSpeed(_duration,GetDistance()).ToString("N2")} kph, Pace: {GetPace(_duration,GetDistance()).ToString("N2")} min per km");
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
        return (_speed * _duration)/60;
    }
}

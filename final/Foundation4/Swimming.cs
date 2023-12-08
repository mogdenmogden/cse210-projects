public class Swimming : Activity
{
    private double _duration,_laps;
    private string _date;
    
    public Swimming(string date, double duration, double laps) : base()
    {
        _distance = GetDistance();
        _date = date;
        _duration = duration;
        _laps = laps;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"-- {_date} Swimming ({_duration} min) - Laps {_laps} (or {GetDistance()} km), Speed {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {(GetPace(_duration,_laps)).ToString("N2")} min per km, or {(GetPace(_duration,_laps)/1000*50).ToString("N2")} min per lap");
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
        double km = _laps*50/1000;
        return km;
    }

     protected override double GetSpeed(double duration,double laps)
    {
        return 60*(GetDistance()/duration); //kph
    }

    protected override double GetPace(double duration,double laps)
    {
        return duration/GetDistance(); //min per km
    }
}
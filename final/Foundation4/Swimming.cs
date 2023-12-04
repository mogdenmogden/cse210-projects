public class Swimming : Activity
{
    public Swimming(string date, double duration, double distance) : base(date, duration, distance)
    {
        _date = date;
        _duration = duration;
        _distance = distance; //aka laps here
    }

    public override string GetType()
    {
        return "Swimming";
    }
    
    public override void GetSummary()
    {
        Console.WriteLine($"-- {_date} {GetType()} ({_duration} min) - Laps {_distance} (or {GetDistance(_distance)} km), Speed {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {(GetPace(_duration,_distance)).ToString("N2")} min per km, or {(GetPace(_duration,_distance)/1000*50).ToString("N2")} min per lap");
    }

    protected override double GetDistance(double laps)
    {
        double km = laps*50/1000;
        return km;
    }

     protected override double GetSpeed(double duration,double laps)
    {
        return 60*(GetDistance(laps)/duration); //kph
    }

    protected override double GetPace(double duration,double laps)
    {
        return duration/GetDistance(laps); //min per km
    }
}
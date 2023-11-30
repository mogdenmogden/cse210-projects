public class Swimming : Activity
{
    // private double _laps;
    public new string _type;

    public Swimming(string date, double duration, double distance) : base(date, duration, distance)
    {
        _type = "Swimming";
        // _laps = distance;
        // double lapsToKm = GetDistance(distance);
        // double speed = GetSpeed(lapsToKm,duration);
        // double pace = GetPace(lapsToKm,duration);
        GetSummary(date,duration,distance);
    }

    public override string GetType()
    {
        return "Swimming";
    }
    
    protected override string GetSummary(string date, double duration, double distance)
    {
        Console.WriteLine($"Laps: {GetDistance(distance)} km"); //dist
        Console.WriteLine($"Speed: {GetSpeed(duration,distance)} kph"); //speed
        Console.WriteLine($"Pace: {GetPace(duration,distance)} min per lap"); //pace
        return $" - {date} {GetType()} ({_duration}) - Laps {GetDistance(distance)}, Speed {GetSpeed(duration,distance)} kph, Pace: {GetPace(duration,distance)} min per lap";
    }

    protected override double GetDistance(double laps)
    {
        return laps*(50/1000);
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
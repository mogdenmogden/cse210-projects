public class Swimming : Activity
{
    public new string _type;

    public Swimming(string date, double duration, double distance) : base(date, duration, distance)
    {
        _type = "Swimming";
        _date = date;
        _duration = duration;
        _distance = distance; //aka laps here
        // GetSummary(date,duration,distance);
    }

    public override string GetType()
    {
        return "Swimming";
    }
    
    public override void GetSummary(string date, double duration, double distance)
    {
        Console.WriteLine($"-- {date} {GetType()} ({duration} min) - Laps {distance}, Speed {GetSpeed(duration,distance).ToString("N2")} kph, Pace: {(GetPace(duration,distance)).ToString("N2")} min per km, or {(GetPace(duration,distance)/1000*50).ToString("N2")} min per lap");
        // Console.WriteLine($"Distance: {distance} laps"); //dist
        // Console.WriteLine($"Speed: {GetSpeed(duration,distance).ToString("N2")} kph"); //speed
        // Console.WriteLine($"Pace: {(GetPace(duration,distance)/1000*50).ToString("N2")} min per lap"); //pace
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
public class Running : Activity
{
    public Running(string date, double duration, double distance) : base(date, duration, distance)
    {

    }

    public override void GetSummary()  
    {
        Console.WriteLine($"-- {_date} Running ({_duration} min) - {GetType()} Distance {_distance.ToString("N2")} km, Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km");
    }
}
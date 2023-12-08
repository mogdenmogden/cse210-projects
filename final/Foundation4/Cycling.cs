public class Cycling : Activity
{
    public Cycling(string date, double duration, double distance) : base(date, duration, distance)
    {

    }

    public override void GetSummary()  
    {
        Console.WriteLine($"-- {_date} Cycling ({_duration} min) - {GetType()} Distance {_distance.ToString("N2")} km, Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km");
    }
}
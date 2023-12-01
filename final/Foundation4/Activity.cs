using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    public string _date, _type;
    public double _duration;
    public double _distance,_speed, _pace;

    public Activity(string date, double duration, double distance)
    {
        _type = "general";
        // GetSummary(date,duration,distance);
        
    }

    public new abstract string GetType();

    public virtual void GetSummary(string date, double duration, double distance)
    {
        Console.WriteLine($"Distance: {GetDistance(distance).ToString("N2")} km"); //dist
        Console.WriteLine($"Speed: {GetSpeed(duration, distance).ToString("N2")} kph"); //speed
        Console.WriteLine($"Pace: {GetPace(duration, distance).ToString("N2")} min per km"); //pace
        Console.WriteLine($"-- {date} {GetType()} ({duration} min) - Distance {GetDistance(distance).ToString("N2")} km, Speed: {GetSpeed(duration,distance).ToString("N2")} kph, Pace: {GetPace(duration,distance).ToString("N2")} min per km");
    }

    protected virtual double GetDistance(double distance)
    {
        return distance;
    }

    protected virtual double GetSpeed(double duration,double distance)
    {
        return 60*(distance/duration); //kph
    }

    protected virtual double GetPace(double duration,double distance)
    {
        return duration/distance; //min per km
    }


}
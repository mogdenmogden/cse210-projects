using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    protected string _date;
    protected double _duration;
    protected double _distance,_speed, _pace;

    public Activity(string date, double duration, double distance)
    {
       _date = date;
        _duration = duration;
        _distance = distance;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"-- {_date} {GetType()} ({_duration} min) - Distance {_distance.ToString("N2")} km, Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km");
    }


    protected virtual double GetSpeed(double duration,double distance)
    {
        return 60*(distance/duration); //kph
    }

    protected virtual double GetPace(double duration,double distance)
    {
        return duration/distance; //min per km
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public double GetDistance()
    {
        return _distance;
    }
}
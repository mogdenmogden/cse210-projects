using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    protected string _date, _type;
    protected double _duration;
    protected double _distance,_speed, _pace;

    public Activity(string date, double duration, double distance)
    {
        _type = "general";
    }

    public new abstract string GetType();

    public virtual void GetSummary()
    {
        Console.WriteLine($"-- {_date} {GetType()} ({_duration} min) - Distance {GetDistance(_distance).ToString("N2")} km, Speed: {GetSpeed(_duration,_distance).ToString("N2")} kph, Pace: {GetPace(_duration,_distance).ToString("N2")} min per km");
    }
    // public abstract void GetSummary();
    //NOTE: Instead of the abstract expression, I interpreted the specification requirement as expressed in the virtual GetSummary() method.
    //I am leaving the abstract in place to demonstrate I can do that, just in case I misunderstood the requirement.

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
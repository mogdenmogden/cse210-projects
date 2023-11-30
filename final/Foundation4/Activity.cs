using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    public string _date, _type;
    public double _duration;
    public double _distance,_speed, _pace;

    public Activity(string date, double duration, double distance)
    {
        _type = "general";
        // _distance = distance; //in km
        // _duration = duration; //in minutes
        // _date = date;

        GetSummary(date,duration,distance);
    }

    public new abstract string GetType();
    
    // public void SetSummary()
    // {
        
    // }
    
    protected virtual string GetSummary(string date, double duration, double distance)
    {
        Console.WriteLine($"Distanc: {GetDistance(distance)} km"); //dist
        Console.WriteLine($"Speed: {GetSpeed(duration, distance)} kph"); //speed
        Console.WriteLine($"Pace: {GetPace(duration, distance)} min per km"); //pace
        return $" - {_date} {GetType()} ({_duration}) - Distance {GetDistance(distance)} km, Speed: {GetSpeed(duration,distance)} kph, Pace: {GetPace(duration,distance)} min per km";
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
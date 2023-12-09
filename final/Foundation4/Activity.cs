using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    protected double _distance;
    public abstract void GetSummary();
    
    protected virtual double GetSpeed(double duration,double distance)
    {
        return 60*(distance/duration); //kph
    }

    protected virtual double GetPace(double duration,double distance)
    {
        return duration/distance; //min per km
    }

    public abstract string GetDate();
    
    public abstract double GetDuration();

    public virtual double GetDistance()
    {
        return _distance;
    }
}
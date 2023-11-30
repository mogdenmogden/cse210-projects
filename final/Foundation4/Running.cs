public class Running : Activity
{
    public new string _type;

    public Running(string date, double duration, double distance) : base(date, duration, distance)
    {
        _type = "Running";
        GetSummary(date,duration,distance);
    }

    public override string GetType()
    {
        return "Running";
    }
    // protected override double GetPace() 
    // {
    //     return 0.0;
    // }

    // protected override double GetSpeed()
    // {
    //     return 0.0;
    // }
}
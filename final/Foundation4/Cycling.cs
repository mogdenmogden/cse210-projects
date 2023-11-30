public class Cycling : Activity
{
    public new string _type;

    public Cycling(string date, double duration, double distance) : base(date, duration, distance)
    {
        _type = "Cycling";
        GetSummary(date,duration,distance);
    }

    public override string GetType()
    {
        return "Cycling";
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
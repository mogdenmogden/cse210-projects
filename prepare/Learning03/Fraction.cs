using System.Globalization;

public class Fraction
{
    private int _top;
    private int _bottom;

    public void Numbers()
    {
        _top = 1;
        _bottom = 1;
    }
    public void Numbers(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }
    public void Numbers(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }
    public int GetTop()
    {
        return _top;
    }
     public void SetTop(int top)
    {
        top = _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
     public void SetBottom(int bottom)
    {
        bottom = _bottom;
    }

    public string GetFractionString()
    {
        string _fracString = _top.ToString()+"/"+_bottom.ToString();
        return _fracString;
    }
    public double GetDecimalValue()
    {
        double _fracDecimal = Convert.ToDouble(_top)/Convert.ToDouble(_bottom);
        return (double)_top/ _bottom;
        /*return Convert.ToDouble(_top)/Convert.ToDouble(_bottom);*/
    }
}
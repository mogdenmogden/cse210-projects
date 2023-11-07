using System.Drawing;

public class Rectangle : Shape
{
    private double _longSide;
    private double _shortSide;
    
    public Rectangle(string color, int shortSide, int longSide) : base(color)
    {
        SetColor(color);
        _color = GetColor();
        _shortSide = shortSide;
        _longSide = longSide;
    }

    public override double GetArea()
    {
        return _shortSide * _longSide;
    }

    
}
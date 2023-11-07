using System.Drawing;

public class Circle : Shape
{
    private double _radius;
    
    public Circle(string color, int radius) : base(color)
    {
        SetColor(color);
        _color = GetColor();
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }

    
}
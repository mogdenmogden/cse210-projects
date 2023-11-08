using System.Drawing;

public class Square : Shape
{
    private double _side;
    
    public Square(string color, double side) : base(color)
    {
        SetColor(color);
        // _color = GetColor();
        _side = side;
        // SetSide(side);
    }

    public override double GetArea()
    {
        return _side * _side;
    }

    // public void SedSide(double side)
    // {
    //     _side = side;
    // }
    

}
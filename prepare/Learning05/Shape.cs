public abstract class Shape
{
    protected string _color;

    public Shape(string color)
    {
        SetColor(color);
    }

    public abstract double GetArea();

    public string GetColor()
    {
        return _color;
    }

    protected void SetColor(string color)
    {
        _color = color;
    }
    

}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("red", 4);
        string sqColor = square.GetColor();
        double sqArea = square.GetArea();
        Console.WriteLine($"square color: {sqColor}");
        Console.WriteLine($"square area: {sqArea}");
        Console.WriteLine();


        Rectangle rectangle = new Rectangle("blue", 4, 12);
        string recColor = rectangle.GetColor();
        double recArea = rectangle.GetArea();
        Console.WriteLine($"rectangle color: {recColor}");
        Console.WriteLine($"rectangle area: {recArea}");
        Console.WriteLine();


        Circle circle = new Circle("green", 4);
        string circColor = circle.GetColor();
        double circArea = circle.GetArea();
        Console.WriteLine($"circle color: {circColor}");
        Console.WriteLine($"circle area: {circArea}");
        Console.WriteLine();
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("orange", 3));
        shapes.Add(new Circle("purple", 7));
        shapes.Add(new Rectangle("yellow", 3,5));
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The shape is a {color} {shape} with an area of {area} square units.");
        }
    }
}
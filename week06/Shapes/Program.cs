using System;

public class Program
{
    private string _color;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("Red", 5);
        Console.WriteLine($"The area of the {square.Color()} square is: {square.Area()}");
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"The area of the {rectangle.Color()} rectangle is: {rectangle.Area()}");
        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"The area of the {circle.Color()} circle is: {circle.Area()}");
    }

    public string Color()
    {
        return _color;
    }
    public Program(string color)
    {
        _color = color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double Area()
    {
        return 0;
    }
}
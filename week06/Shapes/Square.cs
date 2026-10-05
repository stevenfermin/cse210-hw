public class Square : Program
{
    private double _side;

    public Square(string color, double sideLength) : base(color)
    {
        _side = sideLength;
    }

    public override double Area()
    {
        return _side * _side;
    }
}
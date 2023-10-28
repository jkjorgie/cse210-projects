class Circle : Shape
{
    private double _rad;
    public Circle(string color, double radius): base(color)
    {
        _rad = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _rad * _rad;
    }
}
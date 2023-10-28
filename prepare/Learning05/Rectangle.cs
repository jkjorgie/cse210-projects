class Rectangle : Shape
{
    private double _len;
    private double _width;
    public Rectangle(string color, double len, double width): base(color)
    {
        _len = len;
        _width = width;
    }

    public override double GetArea()
    {
        return _len * _width;
    }
}
abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        this.SetColor(color);
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}
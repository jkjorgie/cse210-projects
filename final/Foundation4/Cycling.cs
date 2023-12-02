using System.Globalization;
using System.Runtime.InteropServices;

class Cycling : Activity
{
    private double _speed;

    public Cycling(int length, string date, double speed) : base(length, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _length / 60;
    }
}
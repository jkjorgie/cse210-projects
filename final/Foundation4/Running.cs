using System.Globalization;
using System.Runtime.InteropServices;

class Running : Activity
{
    private double _distance;

    public Running(int length, string date, double distance) : base(length, date)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
}
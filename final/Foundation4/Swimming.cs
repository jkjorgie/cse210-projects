using System.Globalization;
using System.Runtime.InteropServices;

class Swimming : Activity
{
    private int _lapCount;

    public Swimming(int length, string date, int lapCount) : base(length, date)
    {
        _lapCount = lapCount;
    }

    public override double GetDistance()
    {
        return _lapCount * 50 / 1000 * .62;
    }
}
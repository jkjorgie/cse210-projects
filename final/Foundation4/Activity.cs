using System.Globalization;
using System.Runtime.InteropServices;

abstract class Activity
{
    protected int _length;
    protected string _date;

    public Activity(int length, string date)
    {
        _length = length;
        _date = date;
    }
    public abstract double GetDistance();
    public virtual double GetSpeed()
    {
        return this.GetDistance() / _length * 60;
    }
    public virtual double GetPace()
    {
        return _length / this.GetDistance();
    }
    public virtual string GetSummary()
    {
        return $"{_date} {this.ToString()} ({_length} min): Distance {this.GetDoubleText(this.GetDistance())} miles, Speed {this.GetDoubleText(this.GetSpeed())} mph, Pace: {this.GetDoubleText(this.GetPace())} min per mile";
    }

    private string GetDoubleText(double _value)
    {
        return _value.ToString("F1");
    }
}
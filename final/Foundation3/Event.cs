using System.Globalization;
using System.Runtime.InteropServices;

abstract class Event
{
    protected string _title;
    protected string _descr;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string descr, string date, string time, string streetAddress, string city, string state, string country)
    {
        _title = title;
        _descr = descr;
        _date = date;
        _time = time;
        _address = new Address(streetAddress, city, state, country);
    }

    public virtual string GetStandardDetails()
    {
        return $"{_title} - {_descr}\n{_date} {_time}\n{_address.GetAddress()}";
    }
    public abstract string GetFullDetails();
    public virtual string GetShortDescr()
    {
        return $"{this.ToString()}: {_title} - {_date}";
    }
}
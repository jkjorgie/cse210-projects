using System.Globalization;
using System.Runtime.InteropServices;

class Lecture : Event
{
    private string _speaker;
    private int _maxAttendees;

    public Lecture(string title, string descr, string date, string time, string streetAddress, string city, string state, string country, string speaker, int maxAttendees) : base(title, descr, date, time, streetAddress, city, state, country)
    {
        _speaker = speaker;
        _maxAttendees = maxAttendees;
    }

    public override string GetFullDetails()
    {
        string details = this.GetStandardDetails() + "\n";
        details += "Speaker: " + _speaker + "\n";
        details += "Max Attendees: " + _maxAttendees;

        return details;
    }
}
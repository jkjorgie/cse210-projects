using System.Globalization;
using System.Runtime.InteropServices;

class Reception : Event
{
    private string _registrationText;

    public Reception(string title, string descr, string date, string time, string streetAddress, string city, string state, string country) : base(title, descr, date, time, streetAddress, city, state, country)
    {
        _registrationText = "You must RSVP to attend!";
    }

    public override string GetFullDetails()
    {
        string details = this.GetStandardDetails() + "\n";
        details += _registrationText;

        return details;
    }
}
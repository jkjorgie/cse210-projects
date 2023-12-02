using System.Globalization;
using System.Runtime.InteropServices;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string descr, string date, string time, string streetAddress, string city, string state, string country, string weatherForecast) : base(title, descr, date, time, streetAddress, city, state, country)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetWeatherForecast()
    {
        return "Weather Forecast: " + _weatherForecast;
    }

    public override string GetFullDetails()
    {
        string details = this.GetStandardDetails() + "\n";
        details += "Weather Forecast: " + _weatherForecast;

        return details;
    }
}
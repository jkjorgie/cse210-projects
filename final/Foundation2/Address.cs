    // Address
    //     Properties
    //         * streetAddress
    //         * city
    //         * state
    //         * country
    //     Methods
    //         * IsInUSA
    //         * GetInfo

using System.Globalization;
using System.Runtime.InteropServices;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return (_country == "USA");
    }

    public string GetAddress()
    {
        string ret = _streetAddress + "\n";
        ret += _city + ", " + _state + " " + _country;

        return ret;
    }
}
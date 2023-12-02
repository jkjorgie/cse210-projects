    // Customer
    //     Properties
    //         * name
    //         * Address
    //     Methods
    //         * IsInUSA

using System.Globalization;
using System.Net.Sockets;
using System.Runtime.InteropServices;

class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, string streetAddr, string city, string state, string country)
    {
        _name = name;
        _address = new Address(streetAddr, city, state, country);
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        string label = _name + "\n" + _address.GetAddress();
        return label;
    }
}
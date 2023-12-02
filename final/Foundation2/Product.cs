    // Product
    //     Properties 
    //         * name
    //         * product id
    //         * price
    //         * quantity (?)
    //     Methods
    //         * GetCost
    //         * GetInfo

using System.Globalization;
using System.Runtime.InteropServices;

class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;


    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetCost()
    {
        return _price * _quantity;
    }

    public string GetInfo()
    {
        return $"{_name} | ID:{_id} | Price: ${_price} per unit | Units: {_quantity}";
    }
}
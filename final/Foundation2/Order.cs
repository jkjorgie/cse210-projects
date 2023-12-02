        // Properties 
        //     * products (list)
        //     * customer
        // Methods
        //     * CalculateTotalCost
        //     * GetPackingLabel
        //     * GetShippingLabel
        //     * CalculateShipping
        //     * CalculateProductsCost

using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(string name, string streetAddr, string city, string state, string country)
    {
        _products = new List<Product>();
        _customer = new Customer(name, streetAddr, city, state, country);
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }

    public string GetPackingLabel()
    {
        string ret = "~Packing Label~\n";
        for (int i = 0; i < _products.Count; i++)
        {
            ret += _products[i].GetInfo() + "\n";
        }
        return ret;
    }

    public string GetShippingLabel()
    {
        string ret = "~Shipping Label~\n";

        ret += _customer.GetShippingLabel();

        return ret;
    }

    public string GetTotalPrice()
    {
        double cost = 0.0;

        for (int i = 0; i < _products.Count; i++)
        {
            cost += _products[i].GetCost();
        }

        cost += this.GetShippingCost();

        return $"${cost}";
    }

    private double GetShippingCost()
    {
        double cost;

        if (_customer.IsInUSA())
        {
            cost = 5.0;
        }
        else
        {
            cost = 35.0;
        }

        return cost;
    }
}
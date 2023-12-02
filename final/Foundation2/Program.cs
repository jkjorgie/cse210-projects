using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Clear();

        Order o1 = new Order("Harry Potter", "123 N Main", "Toronto", "Ontario", "Canada");
        o1.AddProduct("iPhone 13", "11111", 1100.00, 1);
        o1.AddProduct("AirPods Pro", "22222", 125.00, 2);
        o1.AddProduct("Bananas", "33333", 1.0, 10);

        Order o2 = new Order("Hermione Granger", "456 E State St", "Orem", "UT", "USA");
        o2.AddProduct("Calculus Book", "44444", 250.00, 1);
        o2.AddProduct("Cat Food", "55555", .1, 1500);

        List<Order> orders = new List<Order>();
        orders.Add(o1);
        orders.Add(o2);

        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Order [{i + 1}]:");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine("Total Price: " + orders[i].GetTotalPrice());
        }
    }
}
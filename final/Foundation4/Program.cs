using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Running r  = new Running(30, "02 Dec 2023", 3.0);
        Cycling c = new Cycling(60, "04 Dec 2023", 15.0);
        Swimming s = new Swimming(45, "05 Dec 2023", 30);

        List<Activity> activities = new List<Activity>();
        activities.Add(r);
        activities.Add(c);
        activities.Add(s);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
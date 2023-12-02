using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Lecture l = new Lecture("How to Win Friends and Influence People", "Learn how to make others like you, gain their trust, and impact the world.", "05/15/2024", "7:00PM MT", "123 Main", "Provo", "UT", "USA", "Charles Barkley", 100);
        Reception r = new Reception("Ron & Hermione's Wedding", "Come celebrate Mr. and Mrs. Weasley's marriage!","12/31/2023","6:00PM MT", "456 State St", "Salt Lake City", "UT", "USA");
        OutdoorGathering o = new OutdoorGathering("Christmas Lights at Temple Square", "Come see the beautiful temple lights with the entire family!", "12/24/2023", "5:00PM MT", "100 N Temple", "Salt Lake City", "UT", "USA", "High of 20 degrees fahrenheit with clear skies.");

        List<Event> events = new List<Event>();
        events.Add(l);
        events.Add(r);
        events.Add(o);

        Event e;
        for (int i = 0; i < events.Count; i++)
        {
            e = events[i];
            Console.WriteLine(e.GetShortDescr() + "\n");
            Console.WriteLine(e.GetStandardDetails() + "\n");
            Console.WriteLine(e.GetFullDetails() + "\n");
            Console.WriteLine();
        }
    }
}
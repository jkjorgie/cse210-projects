using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 5.0));
        shapes.Add(new Rectangle("yellow", 5.0, 10.0));
        shapes.Add(new Circle("green", 7.0));

        for (int i = 0; i < shapes.Count; i++)
        {
            Console.WriteLine($"{shapes[i].ToString()}: {shapes[i].GetColor()}, {shapes[i].GetArea()}");
        }

        // Square s = new Square("blue", 5.0);
        // Console.WriteLine($"Square: {s.GetColor()}, {s.GetArea()}");

        // Rectangle r = new Rectangle("yellow", 5.0, 10.0);
        // Console.WriteLine($"Rectangle: {r.GetColor()}, {r.GetArea()}");

        // Circle c = new Circle("green", 7.0);
        // Console.WriteLine($"Circle: {c.GetColor()}, {c.GetArea()}");

        Console.ReadLine();
    }
}
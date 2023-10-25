using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        num = SquareNumber(num);
        DisplayResult(name, num);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int _num)
    {
        return (int)Math.Pow(_num, 2);
    }

    static void DisplayResult(string _name, int _num) {
        Console.WriteLine($"{_name}, the square of your number is {_num}");
    }
}
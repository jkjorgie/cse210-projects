using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        double pct = double.Parse(Console.ReadLine());
        string letterGrade = "";
        if (pct >= 90) {
            letterGrade = "A";
        }
        else if (pct >= 80) {
            letterGrade = "B";
        }
        else if (pct >= 70) {
            letterGrade = "C";
        }
        else if (pct >= 60) {
            letterGrade = "D";
        }
        else {
            letterGrade = "F";
        }

        if (letterGrade != "A" && letterGrade != "F") {
            if (pct % 10 >= 7){
                letterGrade += "+";
            }
            else if (pct % 10 < 3) {
                letterGrade += "-";
            }
        }

        Console.WriteLine($"You got: {letterGrade}");

        if (pct >= 70) {
            Console.WriteLine("You passed!");
        }
        else {
            Console.WriteLine("Better luck next time.");
        }
    }
}
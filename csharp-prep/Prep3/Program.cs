using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Console.Write("Give me a magic number: ");
        Random rand = new Random();
        int num = rand.Next(1,101);

        int guess = 0;
        while (guess != num) {
        Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > num) {
                Console.WriteLine("Lower");
            }
            else if (guess < num) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
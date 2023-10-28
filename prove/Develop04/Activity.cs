public class Activity
{
    private string _name;
    private string _descr;
    protected int _sessionSeconds;
    private string[] _chars;

    public Activity(string name, string descr)
    {
        _name = name;
        _descr = descr;
        _chars = new string[] {"|", "/", "-", "\\"};
    }

    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_descr);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _sessionSeconds = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        this.DisplaySpinner(3);
    }

    protected void CompleteActivity()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        this.DisplaySpinner(3);
        Console.WriteLine($"\nYou have completed another {_sessionSeconds} seconds of the {_name} Activity.");
        this.DisplaySpinner(3);
    }

    protected void DisplaySpinner(int duration)
    {
        
        int charNdx = 0;
        for (int i = 0; i < duration * 2; i++) // run for duration * 2 because each char will display for .5s
        {
            Console.Write(_chars[charNdx]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            charNdx += 1;
            if (charNdx > _chars.Length - 1) //reset char index if it gets too high
            {
                charNdx = 0;
            }
        }
    }

    protected int DisplaySpinnerUntilUserAction()
    {
        int count = 0;
        int charNdx = 0;
        while (!Console.KeyAvailable)
        {
            Console.Write(_chars[charNdx]);
            Thread.Sleep(500); // Adjust the speed of the spinner here
            Console.Write("\b \b");
            charNdx += 1;
            if (charNdx > _chars.Length - 1) //reset char index if it gets too high
            {
                charNdx = 0;
            }
            count++;
        }

        ConsoleKeyInfo cki = Console.ReadKey(true);

        return count / 2; //cycle runs every .5s.. return count / 2 rounded to nearest int for seconds duration
    }

    protected void DisplayTimer(int duration)
    {
        while (duration > 0)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration -= 1;
        }
    }
}
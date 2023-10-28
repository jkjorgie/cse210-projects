public class ListingActivity : PromptActivity
{
    private int _responseCount;
    public ListingActivity(string name, string descr): base(name, descr)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        _responseCount = 0;
    }

    public new void RunActivity()
    {
        base.RunActivity();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        this.ServePrompt();
        Console.Write("You may begin in: ");
        this.DisplayTimer(3);
        Console.WriteLine();
        this.CollectResponses();
        Console.WriteLine($"You listed {_responseCount} items!");

        this.CompleteActivity();
    }

    private void CollectResponses()
    {
        TimeSpan timeDiff;
        int elapsedTime = 0;
        DateTime responseStartTime;
        string response = "";
        while (elapsedTime < _sessionSeconds)
        {
            responseStartTime = DateTime.Now;
            Console.Write("> ");
            response = Console.ReadLine();
            _responseCount++;
            timeDiff = DateTime.Now - responseStartTime;
            elapsedTime += (int)timeDiff.TotalSeconds;
        }
    }
}
public class BreathingActivity : Activity
{
    private int _inDuration;
    private int _outDuration;
    public BreathingActivity(string name, string descr): base(name, descr)
    {
        _inDuration = 4;
        _outDuration = 4;
    }

    public new void RunActivity()
    {
        base.RunActivity();

        int timer = 0;
        while (timer <= _sessionSeconds)
        {
            Console.WriteLine();
            Console.Write("\nBreathe in...");
            this.DisplayTimer(_inDuration);
            timer += _inDuration;

            Console.Write("\nNow breathe out...");
            this.DisplayTimer(_outDuration);
            timer += _outDuration;
        }

        this.CompleteActivity();
    }
}
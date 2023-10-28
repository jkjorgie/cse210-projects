public class ReflectionActivity : PromptActivity
{
    private List<string> _questions;
    private List<int> _usedIndexes;
    public ReflectionActivity(string name, string descr): base(name, descr)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        _usedIndexes = new List<int>();
    }

    public new void RunActivity()
    {
        base.RunActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        this.ServePrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string resp = Console.ReadLine();
        Console.WriteLine("Now, ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        this.DisplayTimer(3);
        Console.Clear();
        this.ServeQuestions();

        this.CompleteActivity();
    }

    private void ServeQuestions()
    {
        int duration = 0;
        int ndx;
        Random rand = new Random();
        while (duration <= _sessionSeconds)
        {
            this.ResetUsedIndexesIfNeeded();
            do
            {
                ndx = rand.Next(_questions.Count);
            } while (_usedIndexes.Contains(ndx));
            _usedIndexes.Add(ndx);
            Console.Write("\n> " + _questions[ndx] + " ");
            int durReflected = this.DisplaySpinnerUntilUserAction();
            duration += durReflected;
        }
    }

    private void ResetUsedIndexesIfNeeded()
    {
        if (_usedIndexes.Count == _questions.Count) //all questions have been used
        {
            _usedIndexes = new List<int>();
        }
    }
}
class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        this.PopulatePrompts();
    }

    public void PopulatePrompts()
    {
        this._prompts = new List<string>();
        this._prompts.Add("Who was the most interesting person I interacted with today?");
        this._prompts.Add("What was the best part of my day?");
        this._prompts.Add("What did you accomplish that you are most proud of today?");
        this._prompts.Add("What was the strongest emotion I felt today?");
        this._prompts.Add("If I had one thing I could do over today, what would it be?");
        this._prompts.Add("How did you help someone today?");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int ndx = rand.Next(this._prompts.Count);
        return this._prompts[ndx];
    }
}
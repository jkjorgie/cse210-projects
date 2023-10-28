public class PromptActivity : Activity
{
    protected const string _PROMPT_HDR_SFX = " --- ";
    protected List<string> _prompts;
    private List<int> _runIndexes;
    public PromptActivity(string name, string descr): base(name, descr)
    {
        _prompts = new List<string>();
        _runIndexes = new List<int>();
    }

    protected void ServePrompt()
    {
        this.ResetRunIndexesIfNeeded();

        Random rand = new Random();
        int ndx;
        do
        {
            ndx = rand.Next(_prompts.Count);
        } while (_runIndexes.Contains(ndx));
        _runIndexes.Add(ndx);
        Console.WriteLine(_PROMPT_HDR_SFX + _prompts[ndx] + _PROMPT_HDR_SFX);
    }

    private void ResetRunIndexesIfNeeded()
    {
        if (_runIndexes.Count == _prompts.Count) //all prompts have been used
        {
            _runIndexes = new List<int>();
        }
    }
}
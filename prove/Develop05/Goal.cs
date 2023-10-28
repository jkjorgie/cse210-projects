abstract class Goal
{
    private string _name;
    protected int _points;
    protected string _descr;
    protected bool _complete;

    public Goal()
    {
        _name = "";
        _descr = "descr";
        _points = 0;

        _complete = false;
    }

    public Goal(string name, string descr, int points)
    {
        _name = name;
        _descr = descr;
        _points = points;

        _complete = false;
    }

    public virtual void Complete()
    {
        _complete = true;
    }

    public virtual string GetGoalAsListString()
    {
        string checkmark = " ";
        if (this.IsComplete())
        {
            checkmark = "X";
        }

        return $"[{checkmark}] {_name} ({_descr})";
    }

    public virtual bool IsComplete()
    {
        return _complete;
    }

    public virtual int GetPoints()
    {
        if (this.IsComplete())
        {
            return _points;
        }

        return 0;
    }

    public virtual string GetGoalAsSaveString()
    {
        string text = "";

        text = $"{this.ToString()}|{_name}|{_descr}|{_points}|{_complete}";

        return text;
    }

    public virtual void LoadGoalFromString(string text)
    {
        string[] parts = text.Split("|");
        
        //type = parts[0];
        _name = parts[1];
        _descr = parts[2];
        _points = int.Parse(parts[3]);
        _complete = (parts[4] == "True");
    }

    public string GetName()
    {
        return _name;
    }

    public abstract Goal Clone(string name);
}
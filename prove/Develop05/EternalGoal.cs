class EternalGoal : Goal
{
    private int _completeCount;

    public EternalGoal():base()
    {
        _completeCount = 0;
    }

    public EternalGoal(string name, string descr, int points):base(name, descr, points)
    {
        _completeCount = 0;
    }

    public override int GetPoints()
    {
        return _completeCount * _points;
    }

    public override string GetGoalAsSaveString()
    {
        string text = base.GetGoalAsSaveString();

        text += $"|{_completeCount}";

        return text;
    }

    public override void LoadGoalFromString(string text)
    {
        base.LoadGoalFromString(text);

        string[] parts = text.Split("|");
        _completeCount = int.Parse(parts[5]);
    }

    public override void Complete()
    {
        _completeCount += 1;
    }

    public override EternalGoal Clone(string name)
    {
        EternalGoal eg = new EternalGoal(name, _descr, _points);
        eg._complete = false;
        eg._completeCount = 0;
        
        return eg;
    }
}
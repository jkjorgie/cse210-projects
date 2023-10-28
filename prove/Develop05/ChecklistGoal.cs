class ChecklistGoal : Goal
{
    private int _bonusCount;
    private int _bonusPoints;
    private int _countCompleted;

    public ChecklistGoal():base()
    {
        _bonusCount = 0;
        _bonusPoints = 0;
        _bonusPoints = 0;
    }

    public ChecklistGoal(string name, string descr, int points, int bonusCount, int bonusPoints):base(name, descr, points)
    {
        _bonusCount = bonusCount;
        _bonusPoints = bonusPoints;
        _countCompleted = 0;
    }

    public override string GetGoalAsListString()
    {
        string text = base.GetGoalAsListString();
        text += $" --- Currently completed: {_countCompleted}/{_bonusCount}";

        return text;
    }

    public override bool IsComplete()
    {
        return (_bonusCount == _countCompleted);
    }

    public override void Complete()
    {
        _countCompleted += 1;
        if (this.IsComplete())
        {
            base.Complete();
        }
    }

    public override int GetPoints()
    {
        int points = _countCompleted * _points;
        if (this.IsComplete())
        {
            points += _bonusPoints;
        }
        
        return points;
    }

    public override string GetGoalAsSaveString()
    {
        string text = base.GetGoalAsSaveString();

        text += $"|{_bonusPoints}|{_bonusCount}|{_countCompleted}";

        return text;
    }

    public override void LoadGoalFromString(string text)
    {
        base.LoadGoalFromString(text);

        string[] parts = text.Split("|");
        _bonusPoints = int.Parse(parts[5]);
        _bonusCount = int.Parse(parts[6]);
        _countCompleted = int.Parse(parts[7]);
    }

    public override ChecklistGoal Clone(string name)
    {
        ChecklistGoal cg = new ChecklistGoal(name, _descr, _points, _bonusCount, _bonusPoints);
        cg._complete = false;
        cg._countCompleted = 0;

        return cg;
    }
}
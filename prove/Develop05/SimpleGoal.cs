class SimpleGoal : Goal
{
    public SimpleGoal():base()
    {
    }

    public SimpleGoal(string name, string descr, int points):base(name, descr, points)
    {

    }

    public override SimpleGoal Clone(string name)
    {
        SimpleGoal sg = new SimpleGoal(name, _descr, _points);
        sg._complete = false;
        return sg;
    }
}
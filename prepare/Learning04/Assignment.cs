class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studName, string topic)
    {
        _studentName = studName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
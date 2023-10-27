class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studName, string topic, string title) : base(studName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // This is needed if the name variable is private, not protected.
    public string GetStudentName()
    {
        return _studentName;
    }

    // A getter for the topic variable is also suggested, though not used here.
}
public class WritingAssignment : Assignment
{
    private string _assignmentTitle;

    public WritingAssignment(string name, string topic, string title) : base (name, topic)
    {
        _assignmentTitle = title;
    }

    public string GetWritingInformation()
    {
        // This uses a "protected"-level variable.
        return $"{_assignmentTitle} by {_studentName}"; // or "by {GetStudentName()}"
    }
}
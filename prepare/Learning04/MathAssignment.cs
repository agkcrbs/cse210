public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _sectionProblems;

    // The latter parameters are said to pass directly TO the base constructor, not FROM it to this one.
    public MathAssignment(string name, string topic, string section, string problems) : base (name, topic)
    {
        _textbookSection = section;
        _sectionProblems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_sectionProblems}";
    }
}
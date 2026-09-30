public class MathAssignments : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignments(string author, string topic, string textbook, string problems) : base(author, topic)
    {
        _textbookSection = textbook;
        _problems = problems;
    }
    public string GetHomeworkLis()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
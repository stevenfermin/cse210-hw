using System.Net;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string author, string topic, string title) : base(author, topic)
    {
        _title =  title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {GetName()}";
    }
}
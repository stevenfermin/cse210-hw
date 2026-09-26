public class Comment
{
    private Dictionary<string, Dictionary<string, List<string>>> _allComments = new Dictionary<string, Dictionary<string, List<string>>>();
    private Dictionary<string, List<string>> _comments1 = new Dictionary<string, List<string>>();
    List<string> _comments1Items = new List<string>();
    

    public void setText(string title, string user, string text)
    {
        if (!_allComments.ContainsKey(title))
    {
        var userComments = new Dictionary<string, List<string>>();
        var commentList = new List<string> { text };
        
        userComments.Add(user, commentList);
        _allComments.Add(title, userComments);
    }
    else if (!_allComments[title].ContainsKey(user))
    {
        var commentList = new List<string> { text };
        _allComments[title].Add(user, commentList);
    }
    else
    {
        _allComments[title][user].Add(text);
    }
    }

    public Dictionary<string, Dictionary<string, List<string>>> getText()
    {
        return _allComments;
    }
}
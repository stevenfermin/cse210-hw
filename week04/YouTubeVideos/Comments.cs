public class Comment
{
    private Dictionary<string, Dictionary<string, List<string>>> allComments = new Dictionary<string, Dictionary<string, List<string>>>();
    private Dictionary<string, List<string>> comments1 = new Dictionary<string, List<string>>();
    List<string> comments1Items = new List<string>();
    

    public void setText(string title, string user, string text)
    {
        if (!allComments.ContainsKey(title))
    {
        var userComments = new Dictionary<string, List<string>>();
        var commentList = new List<string> { text };
        
        userComments.Add(user, commentList);
        allComments.Add(title, userComments);
    }
    else if (!allComments[title].ContainsKey(user))
    {
        var commentList = new List<string> { text };
        allComments[title].Add(user, commentList);
    }
    else
    {
        allComments[title][user].Add(text);
    }
    }

    public Dictionary<string, Dictionary<string, List<string>>> getText()
    {
        return allComments;
    }
}
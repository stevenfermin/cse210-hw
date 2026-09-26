public class Video
{
    private Dictionary<string, List<string>> _videos = new Dictionary<string, List<string>>();
    private Dictionary<string, Dictionary<string, List<string>>> _allComments = new Dictionary<string, Dictionary<string, List<string>>>();


    private string _author;
    private string _title;
    private string _duration;
    public void setVideo(string  author, string title, string duration)
    {
        _author = author;
        _title = title;
        _duration = duration;
        List<string> video = new List<string>();
        video.Add(title);
        video.Add(duration);
        _videos.Add(author, video);
    }

    public void setComment(Dictionary<string, Dictionary<string, List<string>>> allComments)
    {
        this._allComments = allComments;
    }

    public Dictionary<string, List<string>> getVideo()
    {
        return _videos;
    }

    public void getVideoTest()
    {
        foreach (var kvp in _videos)
        {
            Console.WriteLine($"Author: {kvp.Key}, Title: {kvp.Value[0]}, duration: {kvp.Value[1]}");
            foreach (var text in _allComments)
            {
                if (text.Key == kvp.Value[0])
                {
                    int numberOfComments = 0;
                    Console.WriteLine();
                    for (int i = 0; i < text.Value.Count; i++)
                    {
                        numberOfComments += text.Value.ElementAt(i).Value.Count;
                    }
                    Console.WriteLine($"\"{numberOfComments} Comments\"");
                    foreach (var userComment in text.Value)
                    {
                        foreach (var comment in userComment.Value)
                        {
                            Console.WriteLine($" {userComment.Key} \"{comment}\"");
                        }
                    }
                }
            };
            Console.WriteLine();
            
        };
        
    }
}
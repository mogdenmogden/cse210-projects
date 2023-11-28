public class Video
{
    public string _title, _author, _duration;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, string time)
    {
        _title = title;
        _author = author;
        _duration = time;
        // _comments = comments;
    }

    public void DisplayVideos()
    {
        Console.WriteLine($"\nVideo Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length(s): {_duration}");
        Console.WriteLine($"Number of Comments: {_comments.Count}");
        foreach (Comment i in _comments)
        {
            i.DisplayCommentLineDetail();
        }
    }

    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

}
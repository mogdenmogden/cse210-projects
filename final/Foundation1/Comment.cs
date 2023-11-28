public class Comment
{
    public string _commentator, _commentText;

    public Comment(string commentMaker, string comment)
    {
        _commentator = commentMaker;
        _commentText = comment;
    }

    public void DisplayCommentLineDetail()
    {
        Console.WriteLine($"\t{_commentator}: \"{_commentText}\"");
    }

}
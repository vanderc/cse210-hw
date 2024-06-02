public class Comment
{
    private string _comment;
    private string _username;

    public Comment(string username, string comment)
    {
        _username = username;
        _comment = comment;
    }

    public void GetCommentInfo()
    {
        Console.WriteLine($"Username: {_username} - {_comment}");
    }
}
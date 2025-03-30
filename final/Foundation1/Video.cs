public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public List<string> GetComments()
    {
        List<string> _commentText = new List<string>();
        foreach (Comment comment in _comments)
        {
            _commentText.Add(comment.ToString());
        }
        return _commentText;
    }
    public override string ToString()
    {
        return $"'{_title}' by {_author} ({_length} sec. long) {NumberOfComments()} comment(s)";
    }
}
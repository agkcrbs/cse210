
public class Video
{
    private string _title;
    private string _author;
    private int _videoLengthSeconds;
    private List<Comment> _commentList;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLengthSeconds = length;
    }

    public string GetHoursMinutesSeconds()
    {
        return TimeSpan.FromSeconds(_videoLengthSeconds).ToString(@"hh\:mm\:ss");
    }

    public string[] GetTitleAuthorLengthArray()
    {
        return new string[]{_title, _author, GetHoursMinutesSeconds(), _videoLengthSeconds.ToString("n0")};
    }

    public int GetCommentNumber()
    {
        return _commentList.Count;
    }

    public void SetCommentList(List<Comment> commentList)
    {
        _commentList = commentList;
    }

    public List<Comment> GetCommentList()
    {
        return _commentList;
    }
}

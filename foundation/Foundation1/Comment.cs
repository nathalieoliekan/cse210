class Comment
{
    private string _commenterName; // create variable for commenter name
    private string _text; // create variable for comment text

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetCommenterName() // get commenter name
    {
        return _commenterName;
    }

    public string GetText() // get comment text
    {
        return _text;
    }
}

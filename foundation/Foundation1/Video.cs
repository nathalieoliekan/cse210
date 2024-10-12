using System.Collections.Generic;

class Video
{
    private string _title; // create variable for video title
    private string _author; // create variable for comment author
    private int _length; // create variable for video length (in seconds)
    private List<Comment> _comments; //  create list of comments

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetCommentCount() // count the number of items in _comments list
    {
        return _comments.Count;
    }

    public string GetDisplayText() // get string text to display
    {
        string displayText = $"Title: {_title}\n" +
                             $"Author: {_author}\n" +
                             $"Length: {_length} seconds\n" +
                             $"Number of Comments: {GetCommentCount()}\n" +
                             $"Comments:\n";

        foreach (var comment in _comments) // add list of comments to displayText string
        {
            displayText += $"- {comment.GetCommenterName()}: {comment.GetText()}\n"; // Updated references to getter methods
        }

        return displayText; // return string of text to display
    }
}

/*
        Properties
            * title
            * author
            * length (in seconds)
            * list of comments
        Methods
            * DisplayInfo
            * GetInfo
            * GetComments
*/
using System.Globalization;
using System.Runtime.InteropServices;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_title}\n{_author} | {this.GetLengthInMinutes()}\n\nComments ({_comments.Count}):");
        for (int i = 0; i < _comments.Count; i++)
        {
            Console.WriteLine("\t" + _comments[i].GetInfo());
        }

    }

    private string GetLengthInMinutes(){
        int minutes = _length / 60;
        int seconds = _length % 60;

        string sMinutes, sSeconds;
        if (minutes == 0)
        {
            sMinutes = "00";
        }
        else
        {
            sMinutes = minutes.ToString();
        }

        if (seconds == 0)
        {
            sSeconds = "00";
        }
        else
        {
            if (seconds < 10)
            {
                sSeconds = "0" + seconds;
            }
            else
            {
                sSeconds = seconds.ToString();
            }
        }

        return $"{minutes}:{seconds}";
    }

    public void AddComment(string author, string text)
    {
        Comment c = new Comment(author, text);
        _comments.Add(c);
    }
}
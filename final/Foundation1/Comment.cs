/*
    Comment
        Properties
            * author
            * text
        Methods
            * GetInfo
*/

using System.Globalization;
using System.Runtime.InteropServices;

class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public string GetInfo()
    {
        return $"{_author}\t{_text}";
    }
}
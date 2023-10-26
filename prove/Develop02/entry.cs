using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Entry
{
    public string _prompt { get; set; }
    public string _text { get; set; }
    public string _date { get; set; }

    public Entry()
    {

    }

    public override string ToString()
    {
        return $"{this._date} -- {this._prompt}\n{this._text}";
    }

    public string ToPipeSeparatedString()
    {
        return $"{this._prompt}|{this._date}|{this._text}";
    }
}
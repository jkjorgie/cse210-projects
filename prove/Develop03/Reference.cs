using System.Globalization;
using System.Runtime.InteropServices;

class Reference
{
    private string _book;
    private int _chapter;
    private int _number;
    private List<Word> _words;

    public Reference(string book, int chapter, int number, string text)
    {
        this.SetReference(book, chapter, number);
        this.SetWords(text);
    }

    public void SetReference(string book, int chapter, int number)
    {
        _book = book;
        _chapter = chapter;
        _number = number;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_number}";
    }

    public int GetVerseNumber()
    {
        return _number;
    }

    public string GetBookAndChapter()
    {
        return $"{_book} {_chapter}";
    }

    public void SetWords(string text)
    {
        _words = new List<Word>();
        string[] parts = text.Split(" ");

        for (int i = 0; i < parts.Length; i++)
        {
            Word word = new Word(parts[i]);
            _words.Add(word);
        }
    }

    public string GetText()
    {
        string text = "";
        for (int i = 0; i < _words.Count; i++)
        {
            if (i != 0)
            {
                text += " ";
            }
            text += _words[i].GetValue();
        }
        return text;
    }
}
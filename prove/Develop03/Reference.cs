using System.Globalization;
using System.Runtime.InteropServices;

class Reference
{
    private string _book;
    private int _chapter;
    //private int _number;
    private List<int> _numbers;
    private List<Word> _words;

    public Reference(string book, int chapter, int number, string text)
    {
        this.SetReference(book, chapter, number);
        this.SetWords(text);
    }

    public Reference(string book, int chapter, List<int> numbers, string text)
    {
        this.SetMultiVerseReference(book, chapter, numbers);
        this.SetWords(text);
    }

    public void SetReference(string book, int chapter, int number)
    {
        _book = book;
        _chapter = chapter;
        _numbers = new List<int>();
        _numbers.Add(number);
    }

    public void SetMultiVerseReference(string book, int chapter, List<int> numbers)
    {
        _book = book;
        _chapter = chapter;
        _numbers = numbers;
    }

    /*public string GetReference()
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
    }*/

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

    public int GetWordCount()
    {
        return _words.Count;
    }

    public void HideWord()
    {
        Random rand = new Random();
        int randNbr = -1;
        bool alreadyHidden = true;
        while (alreadyHidden)
        {
            randNbr = rand.Next(_words.Count);
            if (!_words[randNbr].IsHidden())
            {
                _words[randNbr].Hide();
                alreadyHidden = false;
            }
        }
    }

    public string GetReferenceText()
    {
        string ret = "";

        string verseRange = "";
        if (_numbers.Count == 1)
        {
            verseRange = _numbers[0].ToString();
        }
        else
        {
            int min = 99999;
            int max = 0;
            int curNbr;
            for (int i = 0; i < _numbers.Count; i++)
            {
                curNbr = _numbers[i];
                if (curNbr < min)
                {
                    min = curNbr;
                }
                if (curNbr > max)
                {
                    max = curNbr;
                }
            }
            verseRange = $"{min}-{max}";
        }

        ret = $"{_book} {_chapter}:{verseRange}";

        return ret;
    }

    public bool IsFullyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
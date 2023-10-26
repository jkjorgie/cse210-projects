//creativity: my code will always hide a new word; won't rehide an already hidden word

using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Scripture
{
    List<Reference> _references;
    List<int> _hiddenIndexes;

    public Scripture(Reference reference)
    {
        _references = new List<Reference>();
        _references.Add(reference);

        _hiddenIndexes = new List<int>();
    }

    public Scripture(List<Reference> references)
    {
        _references = references;

        _hiddenIndexes = new List<int>();
    }

    public string GetVerseWithReferenceWithHiddenWords(int hideCount)
    {
        Random rand = new Random();
        string[] parts = this.GetText().Split(" ");
        int wordCount = parts.Length;
        for (int i = 0; i < hideCount; i++)
        {
            if (this.IsFullyHidden())
            {
                break;
            }
            int randNbr = -1;
            while (_hiddenIndexes.IndexOf(randNbr) >= 0 || randNbr < 0)
            {
                randNbr = rand.Next(wordCount);
                if (_hiddenIndexes.IndexOf(randNbr) < 0)
                {
                    _hiddenIndexes.Add(randNbr);
                    break;
                }
            }
        }

        string text = "";
        for (int i = 0; i < parts.Length; i++)
        {
            if (i != 0)
            {
                text += " ";
            }
            if (_hiddenIndexes.IndexOf(i) < 0) // not hidden
            {
                text += parts[i];
            }
            else
            {
                text += this.GetHiddenWord(parts[i]);
            }
        }
        
        return this.GetReference() + " " + text;
    }

    public bool IsFullyHidden()
    {
        string[] parts = this.GetText().Split(" ");
        return _hiddenIndexes.Count == parts.Length;
    }

    public string GetReference()
    {
        if (_references.Count == 1)
        {
            return _references[0].GetReference();
        }

        int min = 999999;
        int max = 0;
        for (int i = 0; i < _references.Count; i++)
        {
            int curVerseNbr = _references[i].GetVerseNumber();
            if (curVerseNbr < min)
            {
                min = curVerseNbr;
            }
            if (curVerseNbr > max)
            {
                max = curVerseNbr;
            }
        }

        //can just get the first index's book/chapter since it will be the same
        return $"{_references[0].GetBookAndChapter()}:{min}-{max}";
    }

    public string GetText()
    {
        string text = "";
        for (int i = 0; i < _references.Count; i++)
        {
            if (i != 0)
            {
                text += " ";
            }
            text += _references[i].GetText();
        }
        return text;
    }

    private string GetHiddenWord(string word)
    {
        string ret = "";
        for (int i = 0; i < word.Length; i++)
        {
            ret += "_";
        }

        return ret;
    }
}
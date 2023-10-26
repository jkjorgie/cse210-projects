//creativity: my code will always hide a new word; won't rehide an already hidden word

using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Scripture
{
    private Reference _reference;

    public Scripture(Reference reference)
    {
        _reference = reference;
    }

    public string GetVerseWithReferenceWithHiddenWords(int hideCount)
    {
        this.HideWords(hideCount);
        
        return this._reference.GetReferenceText() + " " + this._reference.GetText();
    }

    private void HideWords(int hideCount)
    {
        for (int i = 0; i < hideCount; i++)
        {
            _reference.HideWord();
        }
    }

    public bool IsFullyHidden()
    {
        return _reference.IsFullyHidden();
    }
}
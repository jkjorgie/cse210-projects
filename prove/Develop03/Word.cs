class Word
{
    private string _value;
    private bool _hide;
    public Word(string value)
    {
        _value = value;
        _hide = false;
    }

    public string GetValue()
    {
        if (_hide) 
        {
            string ret = "";
            for (int i = 0; i < _value.Length; i++)
            {
                ret += "_";
            }
            return ret;
        }

        return _value;
    }

    public void Hide()
    {
        _hide = true;
    }

    public bool IsHidden()
    {
        return (_hide == true);
    }
}
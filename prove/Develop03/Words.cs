class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden => _isHidden;

    public string Display()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}

class Reference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string Display()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}

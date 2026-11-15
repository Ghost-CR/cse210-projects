// Stores and formats the book, chapter, and verse information for a scripture.
public class Reference
{
    // The book, chapter, and verse range identify this reference.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Create a reference to one verse; zero marks that there is no ending verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; //no final verse
    }

    // Create a reference to a range of verses.
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Return the reference in a readable format, including a range when present.
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }

        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}

// Represents one scripture word and whether it is visible or hidden.
public class Word
{
    // Keep the original word so it can be shown again after being hidden.
    private string _text;

    // Track whether this word should appear as underscores.
    private bool _isHidden;

    // Create a visible word from the supplied text.
    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    // Mark this word as hidden without changing its original text.
    public void Hide()
    {
        _isHidden = true;
    }

    // Make this word visible again.
    public void Show()
    {
        _isHidden = false;
    }

    // Report whether this word is currently hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Return the original word when visible, or matching underscores when hidden.
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}

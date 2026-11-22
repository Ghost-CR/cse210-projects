// A Comment stores one person's name and the text they posted on a video.
public class Comment
{
    private string _name;
    private string _text;

    // Store the values that GetDisplayText later combines for Video.Display.
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Format this comment so its owning Video can display it with the other comments.
    public string GetDisplayText()
    {
        return $"{_name}: {_text}";
    }
}

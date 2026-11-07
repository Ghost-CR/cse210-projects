public class Entry
{
    public string _prompt;
    public string _text;
    public string _date;
    // Zero means this entry came from an older file without a mood rating.
    public int _moodRating;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine($"{_text}");
        if (_moodRating == 0)
        {
            Console.WriteLine("Mood rating: not recorded");
        }
        else
        {
            Console.WriteLine($"Mood rating: {_moodRating}/5");
        }
    }
}

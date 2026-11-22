using System;
using System.Collections.Generic;

// A Video owns its metadata and the Comment objects that belong to it.
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // Initialize the metadata that Display uses when showing this video.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Keep comments in this video so the count and display methods use the same list.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Display calls this method to report the number stored in the comments list.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Display combines the video metadata, the list count, and each Comment's display text.
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");

        // Each Comment formats its own name and text for this video to print.
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
    }
}

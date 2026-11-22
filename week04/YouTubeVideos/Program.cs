using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Main owns the video collection and builds each Video with its comments.
        List<Video> videos = new List<Video>();

        // Each Video constructor stores the metadata that Video.Display later prints.
        Video video1 = new Video("How to make an iron farm in MC", "VegetaSixSeven", 15);
        // AddComment attaches each Comment object to this video for later display.
        video1.AddComment(new Comment("Rocha", "Great video, thanks bro"));
        video1.AddComment(new Comment("Julian", "Looks old"));
        video1.AddComment(new Comment("Samir", "Great video, thanks bro"));
        video1.AddComment(new Comment("Geraldo", "Here we go"));
        // Store the completed Video so the loop can process it with the others.
        videos.Add(video1);

        Video video2 = new Video("How to Beat Artorias in Dark Souls", "SoulsGuide", 720);
        video2.AddComment(new Comment("Mason", "Dodging toward him helped me a lot."));
        video2.AddComment(new Comment("Rina", "Great strategy!"));
        video2.AddComment(new Comment("Leo", "This boss took me so many tries."));
        videos.Add(video2);

        Video video3 = new Video("Easy Chocolate Cake Recipe", "Mia's Kitchen", 480);
        video3.AddComment(new Comment("Liam", "This cake looks delicious."));
        video3.AddComment(new Comment("Emma", "I made this with my family."));
        video3.AddComment(new Comment("Daniel", "Great instructions!"));
        videos.Add(video3);

        // The loop delegates each video's output to its own Display method.
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}

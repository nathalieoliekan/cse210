using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create comments for videos
        var comments1 = new List<Comment>
        {
            new Comment("John", "Video comment text 1"),
            new Comment("Jack", "Video comment text 2"),
            new Comment("Robert", "Video comment text 3")
        };

        var comments2 = new List<Comment>
        {
            new Comment("Angela", "Video comment text 4"),
            new Comment("Alex", "Video comment text 5"),
            new Comment("Marie", "Video comment text 6"),
            new Comment("Lynnette", "Video comment text 7")
        };

        var comments3 = new List<Comment>
        {
            new Comment("Grace", "Video comment text 8"),
            new Comment("Nathalie", "Video comment text 9"),
            new Comment("Bob", "Video comment text 10")
        };

        // Create videos and assign comments
        var video1 = new Video("Video Title Text 1", "Garrett Johnson", 151, comments1);
        var video2 = new Video("Second Video title", "Jane Smith", 27, comments2);
        var video3 = new Video("What video is this?", "Emily Booker", 549, comments3);

        // Add videos to a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
        }
    }
}
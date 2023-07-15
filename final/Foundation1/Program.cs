using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create some videos
        Video video1 = new Video("Video 1", "Author 1", 300);
        video1.Comments.Add(new Comment("Commenter 1", "Great video!"));
        video1.Comments.Add(new Comment("Commenter 2", "I learned a lot from this video."));
        video1.Comments.Add(new Comment("Commenter 3", "Thanks for sharing!"));

        Video video2 = new Video("Video 2", "Author 2", 600);
        video2.Comments.Add(new Comment("Commenter 4", "This video was very helpful."));
        video2.Comments.Add(new Comment("Commenter 5", "I enjoyed watching this video."));

        Video video3 = new Video("Video 3", "Author 3", 900);
        video3.Comments.Add(new Comment("Commenter 6", "This is one of the best videos I've seen on this topic."));
        video3.Comments.Add(new Comment("Commenter 7", "Great job!"));
        video3.Comments.Add(new Comment("Commenter 8", "I can't wait to see more videos from this author."));

        // Add the videos to a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}

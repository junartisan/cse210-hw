using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video vid1 = new Video("How to Bake Bread", "Chef Jane", 600);
        vid1.AddComment(new Comment("Alice", "This was so helpful!"));
        vid1.AddComment(new Comment("Bob", "My crust was too hard, any tips?"));
        vid1.AddComment(new Comment("Charlie", "Delicious results."));
        videos.Add(vid1);

        // Video 2
        Video vid2 = new Video("C# for Beginners", "Code Academy", 1200);
        vid2.AddComment(new Comment("Dave", "Great explanation of classes."));
        vid2.AddComment(new Comment("Eve", "Can you do a video on Interfaces?"));
        vid2.AddComment(new Comment("Frank", "Best tutorial on the web."));
        videos.Add(vid2);

        // Video 3
        Video vid3 = new Video("Top 10 National Parks", "Nature Daily", 450);
        vid3.AddComment(new Comment("Grace", "Yellowstone is my favorite!"));
        vid3.AddComment(new Comment("Heidi", "I need to visit Zion soon."));
        vid3.AddComment(new Comment("Ivan", "The cinematography is stunning."));
        videos.Add(vid3);

        // Iterate and Display
        foreach (var video in videos)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Bake Bread", "Chef Jane", 600);
        v1.AddComment(new Comment("Alice", "This was so helpful!"));
        v1.AddComment(new Comment("Bob", "My crust was too hard, any tips?"));
        v1.AddComment(new Comment("Charlie", "Delicious results."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("C# for Beginners", "Code Academy", 1200);
        v2.AddComment(new Comment("Dave", "Great explanation of classes."));
        v2.AddComment(new Comment("Eve", "Can you do a video on Interfaces?"));
        v2.AddComment(new Comment("Frank", "Best tutorial on the web."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Top 10 National Parks", "Nature Daily", 450);
        v3.AddComment(new Comment("Grace", "Yellowstone is my favorite!"));
        v3.AddComment(new Comment("Heidi", "I need to visit Zion soon."));
        v3.AddComment(new Comment("Ivan", "The cinematography is stunning."));
        videos.Add(v3);

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
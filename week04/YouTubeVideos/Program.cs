using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C#", "Muhammad chamdid", 600);
        video1.Comments.Add(new Comment("Alice", "Great tutorial!"));
        video1.Comments.Add(new Comment("Bob", "Very helpful."));
        video1.Comments.Add(new Comment("Charlie", "Thanks for sharing."));

        Video video2 = new Video("Cooking Pasta", "Zahara noordin", 480);
        video2.Comments.Add(new Comment("David", "Looks delicious!"));
        video2.Comments.Add(new Comment("Emma", "I will try this."));
        video2.Comments.Add(new Comment("Frank", "Easy to follow."));

        Video video3 = new Video("Travel Vlog Uganda", "Sarah noordin", 720);
        video3.Comments.Add(new Comment("Grace", "Beautiful places."));
        video3.Comments.Add(new Comment("Henry", "Amazing video!"));
        video3.Comments.Add(new Comment("Irene", "Loved the scenery."));

        Video video4 = new Video("Football Highlights", "omar mamo", 300);
        video4.Comments.Add(new Comment("Jack", "What a goal!"));
        video4.Comments.Add(new Comment("Kevin", "Best match ever."));
        video4.Comments.Add(new Comment("Lucy", "Exciting highlights."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold the videos
        List<video> videos = new List<video>();


        // Create the first video and add comments
        video video1 = new video("How to Code in C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this."));
        videos.Add(video1);

        // Create the second video and add comments
        video video2 = new video("Introduction to Programming", "Jane Smith", 450);
        video2.AddComment(new Comment("Dave", "This was a great introduction!"));
        video2.AddComment(new Comment("Eve", "I can't wait to learn more!"));
        video2.AddComment(new Comment("Frank", "Thanks for sharing this!"));
        videos.Add(video2);


        // Create the third video and add comments
        video video3 = new video("Advanced C# Programming", "Emily Johnson", 900);
        video3.AddComment(new Comment("Grace", "This is exactly what I needed!"));
        video3.AddComment(new Comment("Heidi", "I learned so much from this video!"));
        video3.AddComment(new Comment("Ivan", "Thanks for the detailed explanation!"));
        videos.Add(video3);

        // Display the video information and comments
        foreach (video video in videos)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

class Program
{
    static void Main()
    {
        // Create videos
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 180),
            new Video("Video 3", "Author 3", 150)
        };

        // Add comments
        videos[0].Comments.Add(new Comment("User 1", "Comment 1 for First Video "));
        videos[0].Comments.Add(new Comment("User 2", "Comment 2 for First Video "));
        videos[1].Comments.Add(new Comment("User 3", "Comment 1 for Second Video "));
        videos[2].Comments.Add(new Comment("User 4", "Comment 1 for Thrid Video "));
        videos[2].Comments.Add(new Comment("User 5", "Comment 2 for Third Video "));

        // Display videos and comments
        foreach (var video in videos)
        {
            Console.WriteLine("Title: {0}", video.Title);
            Console.WriteLine("Author: {0}", video.Author);
            Console.WriteLine("Length: {0} seconds", video.Length);
            Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());
            foreach (var comment in video.Comments)
            {
                Console.WriteLine("Comment by {0}: {1}", comment.CommenterName, comment.Text);
            }
            Console.WriteLine();
        }
    }
}

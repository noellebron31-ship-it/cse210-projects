using System.Collections.Generic;

public class video
{
    public string title { get; set; }
    public string author { get; set; }
    public int length { get; set; }
    public List<Comment> comments = new List<Comment>();

    public video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}
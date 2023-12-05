using System;

public class Video
{
    public string _title;
    public string _author; 
    public double _length; //in seconds
    public List<Comment> _comment = new List<Comment>();
    public int NumberOfComments()
    {
        int Comments = _comment.Count;
        return Comments;
    }
    public void Display()
    {
        Console.WriteLine($"{_title} - {_author} - {_length}s");
        Console.WriteLine($"Number of comments: {NumberOfComments()}")  ;
        foreach (Comment c in _comment)
        {
            c.Display();
        }
    }
}

public class Comment
{
    public string _name;
    public string _comment;
    public void Display()
    {
        Console.WriteLine($"{_name} : {_comment}");
    }
}
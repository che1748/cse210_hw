using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int CountComments()
    {
        return _commentList.Count();
    }

    public void DisplayContent()
    {
        Console.WriteLine($"\ntitle: {_title}\nauthor: {_author}\nlength: {_length} seconds\nNumbers of comments: {CountComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _commentList)
        {
            Console.WriteLine($"{comment.GetComment()} --by {comment.GetPerson()} ");
        }
    }
}
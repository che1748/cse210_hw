using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make a simple sterling engine", "James Lee", 15);
        Comment comment11 = new Comment("Sam", "Keep up the good work!");
        Comment comment12 = new Comment("Cool kid", "Do you have a list of materials you used for building the engine?");
        Comment comment13 = new Comment("Jake", "The power of science indeed!");
        video1.AddComment(comment11);
        video1.AddComment(comment12);
        video1.AddComment(comment13);

        Video video2 = new Video("UVU: An Ideal Husband", "UVU", 136.1);
        Comment comment21 = new Comment("Andrew", "The best performance ever");
        Comment comment22 = new Comment("Drake", "This is kind of a boring play");
        Comment comment23 = new Comment("Peter", "Theatre is the best thing in the world!");
        video2.AddComment(comment21);
        video2.AddComment(comment22);
        video2.AddComment(comment23);

        Video video3 = new Video("Intense study music", "Music Studio", 250);
        Comment comment31 = new Comment("Amy", "I love listening to it when I study!");
        Comment comment32 = new Comment("Ann", "The best study music ever!");
        Comment comment33 = new Comment("James", "This kind of content should be seen more!");
        video3.AddComment(comment31);
        video3.AddComment(comment32);
        video3.AddComment(comment33);

        List<Video> videoLists = new List<Video>()
        {
            video1, video2, video3
        };

        foreach (Video video in videoLists)
        {
            video.DisplayContent();
        }

    }
}
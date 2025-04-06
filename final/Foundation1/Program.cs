using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        var video1 = new Video("Funny Cats", "Robert A", 8);
        video1.AddComment(new Comment("George", "So funny."));
        video1.AddComment(new Comment("Bob", "Not funny."));
        video1.AddComment(new Comment("Joe", "It is very funny."));
        videos.Add(video1);

        var video2 = new Video("Funny Dogs", "George S", 607);
        video2.AddComment(new Comment("Bob", "Funnier than cats."));
        video2.AddComment(new Comment("Susan", "Still not funny."));
        video2.AddComment(new Comment("Ralph", "Very funny."));
        videos.Add(video2);

        var video3 = new Video("Funny Animals", "Stacey E", 3450);
        video3.AddComment(new Comment("Mary", "Not specific enough."));
        video3.AddComment(new Comment("Lauren", "Not funny at all."));
        video3.AddComment(new Comment("Ann", "Haha very funny."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            foreach (string comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
        }

    }
}
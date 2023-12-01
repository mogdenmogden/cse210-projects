using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> videoList =  new List<Video>();
        Console.Clear();
        Video video1 = new Video("How to Eat a Mastodon", "Fred Flintstone", "180");
        Comment v1Comment1 = new Comment("jk@abc.net", "I really like your video. It's great.");
        Comment v1Comment2 = new Comment("BaRubble@bedrock.com", "Fred, how would I eat an elephant using your method?");
        Comment v1Comment3 = new Comment("mslate@quarry.com", "You are late for your shift at the quarry!");
        video1.AddComment(v1Comment1);
        video1.AddComment(v1Comment2);
        video1.AddComment(v1Comment3);
        videoList.Add(video1);
        // video1.DisplayVideos();

        Video video2 = new Video("Hobo Dinners", "King of the Road", "626");
        Comment v2Comment1 = new Comment("alan@gradeshool.edu", "Can I use ground pork instead of hamburger?");
        Comment v2Comment2 = new Comment("wilmaF@bedrock.com", "I love this recipe. I used mastodon in the place of hamburger. My family loved it!");
        Comment v2Comment3 = new Comment("melanie@veganlife.com", "Is there a vegan version of this recipe?");
        video2.AddComment(v2Comment1);
        video2.AddComment(v2Comment2);
        video2.AddComment(v2Comment3);
        videoList.Add(video2);
        // video2.DisplayVideos();

        Video video3 = new Video("Setting Up Your First Aquarium", "Aquaman", "7200");
        Comment v3Comment1 = new Comment("Kat_Enthusiast", "What do you recommend for keeping cats away from the fish?");
        Comment v3Comment2 = new Comment("vatoElvisman", "That's really groovy.  Thanks.");
        Comment v3Comment3 = new Comment("fishfishfish@sea.com", "Love this video!!!");
        video3.AddComment(v3Comment1);
        video3.AddComment(v3Comment2);
        video3.AddComment(v3Comment3);
        videoList.Add(video3);
        // video2.DisplayVideos();

        foreach (Video video in videoList)
        {
            video.DisplayVideos();
        }
        Console.WriteLine();
    }
}
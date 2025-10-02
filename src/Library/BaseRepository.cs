using Ucu.Poo.Twitter;
using System;

namespace Library
{
    public class BaseRepository
    {
        public void TweetPhoto(string post, string path)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(post, path));
        }
    }
}
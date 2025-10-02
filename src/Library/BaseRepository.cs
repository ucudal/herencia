using Ucu.Poo.Twitter;
using System;

namespace Library
{
    public class BaseRepository
    {
        public void TweetPhoto()
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Paul se unio al equipo", @"C:\Users\andre\Downloads\paul.jpg"));
        }
    }
}
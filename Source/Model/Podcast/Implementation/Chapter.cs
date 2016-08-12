using System;
using Podcast.Interfaces;

namespace Podcast.Implementation
{
    public class Chapter : IChapter
    {
        public string Name { get; }
        public TimeSpan Time { get; }
    }
}
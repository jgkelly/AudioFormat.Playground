using System;
using Mp4Chapters;
using Podcast.Interfaces;

namespace Podcast.Implementation
{
    public class Chapter : IChapter
    {
        public Chapter(ChapterInfo info)
        {
            Name = info.Name;
            Time = info.Time;
        }

        public string Name { get; private set; }
        public TimeSpan Time { get; private set; }
    }
}
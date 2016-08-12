using System;
using System.Collections.Generic;
using System.IO;
using Mp4Chapters;
using Podcast.Interfaces;

namespace Podcast.Implementation
{
    public class Episode : IEpisode
    {
        public Episode(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("path Parameter can not be null or empty.");
            }

            GetChapters(path);
        }

        public string Title { get; }
        public string Subtitle { get; }
        public string Description { get; }
        public string Link { get; }
        public string UniqueId { get; }
        public string AlbumArt { get; }
        public bool Explicit { get; }
        public DateTime Published { get; }
        public TimeSpan Duration { get; }
        public IList<string> Keywords { get; }
        public IList<IChapter> Chapters { get; private set; }

        private void GetChapters(string episode)
        {
            using (var inputStream = File.OpenRead(episode))
            {
                var extractor = new ChapterExtractor(new StreamWrapper(inputStream));
                extractor.Run();
                foreach (ChapterInfo chapterInfo in extractor.Chapters)
                {
                    Console.WriteLine("{0} : {1}", chapterInfo.Time, chapterInfo.Name);
                }
            }
        }
    }
}
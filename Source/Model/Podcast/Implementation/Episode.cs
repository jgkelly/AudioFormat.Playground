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

            FilePath = path;
        }

        public string Title { get; }
        public string Subtitle { get; }
        public string Description { get; }
        public string Link { get; }
        public string UniqueId { get; }
        public string AlbumArt { get; }
        public bool Explicit { get; }
        public bool Downloaded { get; }
        public bool Played { get; }
        public string FilePath { get; set; }
        public DateTime Published { get; }
        public TimeSpan Duration { get; }
        public IList<string> Keywords { get; }
        public IList<Chapter> Chapters { get { return GetChapters(); } }

        private IList<Chapter> GetChapters()
        {
            var chapters = new List<Chapter>();

            using (var inputStream = File.OpenRead(FilePath))
            {
                var extractor = new ChapterExtractor(new StreamWrapper(inputStream));
                extractor.Run();
                foreach (var chapterInfo in extractor.Chapters ?? new ChapterInfo[0])
                {
                    chapters.Add(new Chapter(chapterInfo));
                    Console.WriteLine("{0} : {1}", chapterInfo.Time, chapterInfo.Name);
                }
            }

            return chapters;
        }
    }
}
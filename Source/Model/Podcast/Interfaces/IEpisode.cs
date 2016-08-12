using System;
using System.Collections.Generic;

namespace Podcast.Interfaces
{
    /// <summary>
    /// Represents a single podcast episode
    /// </summary>
    public interface IEpisode
    {
        string Title { get; }
        string Subtitle { get; }
        string Description { get; }
        string Link { get; }
        string UniqueId { get; }
        string AlbumArt { get; }
        bool Explicit { get; }
        DateTime Published { get; }
        TimeSpan Duration { get; }
        IList<string> Keywords { get; }
        IList<IChapter> Chapters { get; }
    }
}
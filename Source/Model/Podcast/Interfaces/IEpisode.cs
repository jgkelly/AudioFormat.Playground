using System;
using System.Collections.Generic;
using Podcast.Implementation;

namespace Podcast.Interfaces
{
    /// <summary>
    ///     Represents a single podcast episode
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
        bool Downloaded { get; }
        bool Played { get; }
        DateTime Published { get; }
        TimeSpan Duration { get; }
        IList<string> Keywords { get; }
        IList<Chapter> Chapters { get; }
    }
}
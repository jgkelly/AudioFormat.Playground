using System.Collections.Generic;

namespace Podcast.Interfaces
{
    /// <summary>
    ///     Podcast feed description.
    /// </summary>
    public interface IFeed
    {
        string Title { get; }
        string Copyright { get; }
        string Summary { get; }
        string Link { get; }
        string Language { get; }
        string FullDescription { get; }
        string AlbumArt { get; }
        string Author { get; }
        bool Explicit { get; }
        int PlaybackSpeed { get; }
        List<string> Keywords { get; }
        List<string> Categories { get; }
    }
}
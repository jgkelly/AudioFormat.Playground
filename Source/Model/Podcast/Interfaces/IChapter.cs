using System;

namespace Podcast.Interfaces
{
    /// <summary>
    ///     Chapter description from within a Podcast episode.
    /// </summary>
    public interface IChapter
    {
        string Name { get; }
        TimeSpan Time { get; }
    }
}
using System.Collections.Generic;

namespace Podcast.Interfaces
{
    /// <summary>
    ///     Playlist instance - Collection of Podcast episodes to be played
    /// </summary>
    public interface IPlaylist
    {
        string Name { get; }
        IList<IEpisode> Episodes { get; }
    }
}
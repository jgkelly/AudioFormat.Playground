using System.Collections.Generic;

namespace Podcast.Interfaces
{
    /// <summary>
    /// Represents a source of feeds (i.e. RSS/Podcast). 
    /// </summary>
    public interface ISource
    {
        /// <summary>
        /// Source name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Contains a list of feeds hosted by the source.
        /// </summary>
        IList<IFeed> Feeds { get; }
    }
}

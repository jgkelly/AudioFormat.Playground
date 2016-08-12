using System.Collections.Generic;

namespace Podcast.Interfaces
{
    /// <summary>
    ///     Podcast library
    /// </summary>
    public interface ILibrary
    {
        string Name { get; }
        IList<IFeed> Feeds { get; }
        IList<string> AvailableKeywords { get; }
    }
}
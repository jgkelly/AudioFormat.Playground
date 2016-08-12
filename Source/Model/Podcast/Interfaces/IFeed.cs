using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.Interfaces
{
    interface IFeed
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

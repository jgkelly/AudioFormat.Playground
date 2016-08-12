using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.Interfaces
{
    public interface IChapter
    {
        string Name { get; }
        TimeSpan Time { get; }
    }
}

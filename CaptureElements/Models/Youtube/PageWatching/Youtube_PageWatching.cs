using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{ 
    public class PageWatching : BaseElement
    {
        public WatchingModes? WatchingMode { get; set; }
        public Default_TheaterMode_PageWatching Default_TheaterMode_PageWatching { get; set; }
        public FullScreenMode_PageWatching FullScreenMode_PageWatching { get; set; }

    }
    public enum WatchingModes
    {
        DefaultMode,
        MiniPlayerMode,
        TheaterMode,
        FullScreenMode
    };

}

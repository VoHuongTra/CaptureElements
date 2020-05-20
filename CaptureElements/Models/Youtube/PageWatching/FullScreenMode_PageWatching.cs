using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class FullScreenMode_PageWatching : BaseElement
    {
        public VideoPlayer VideoPlayer { get; set; }
        public VideoWatchingTypes VideoWatchingType { get; set; }

    }
}

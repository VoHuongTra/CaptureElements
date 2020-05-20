
using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Commons
{
    public class Playlist: BaseElement
    {
        public string Title { get; set; }
        public string PlaylistUrl { get; set; }
        public Channel Channel { get; set; }
        public string VideoCount { get; set; }
    }
}

using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class PlaylistBox: BaseElement
    {
        public bool? IsExpanded { get; set; }
        public Button ShowHidePlaylistBtn { get; set; }
        public bool? IsSaved { get; set; }
        public Button SavePlaylistBtn { get; set; }
        public List<Video> Videos { get; set; }
    }
}

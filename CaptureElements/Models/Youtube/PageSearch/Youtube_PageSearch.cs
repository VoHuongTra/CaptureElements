using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using CaptureElements.Models.Youtube.PageSubscription;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageSearch
{
    public class PageSearch : BaseElement
    {
        public List<SubscribedChannel> Channels { get; set; }
        public List<Video> Videos { get; set; }
        public List<Playlist> Playlists { get; set; }
        public Filter Filter { get; set; }
        public SearchRelated SearchRelated { get; set; }
        public Button FilterBtn { get; set; }
        public bool IsFilterOpen { get; set; }


    }
}

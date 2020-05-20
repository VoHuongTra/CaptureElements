using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Guide;
using CaptureElements.Models.Youtube.Header;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube
{
    public class YoutubeModel : BaseElement
    {
        public Header.Header Header { get; set; }
        public Guide.Guide Guide { get; set; }
        public PageChannel.PageChannel PageChannel { get; set; }
        public PageHome.PageHome PageHome { get; set; }
        public PageSearch.PageSearch PageSearch { get; set; }
        public PageSubscription.PageSubscription PageSubscription { get; set; }
        public PageTrending.PageTrending PageTrending { get; set; }
        public PageWatching.PageWatching PageWatching { get; set; }
    }
}

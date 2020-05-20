using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageSubscription
{
    public class PageSubscription : BaseElement
    {
        public Button ManageBtn { get; set; }
        public Button GridBtn { get; set; }
        public Button ListBtn { get; set; }
        public List<SubscribedChannel> SubscribedChannels { get; set; }
        public List<Video> Videos { get; set; }
        public string EnableButton { get; set; }
    }
}

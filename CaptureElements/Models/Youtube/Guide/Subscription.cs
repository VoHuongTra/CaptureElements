
using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Guide
{
    public class Subscription : BaseElement
    {
        public string ChannelName { get; set; }
        public string ChannelUrl { get; set; }
        public bool HasNew { get; set; }
    }
}

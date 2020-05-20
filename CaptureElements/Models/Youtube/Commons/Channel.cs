
using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Commons
{
    public class Channel : BaseElement
    {
        public string Name { get; set; }
        public string ChannelUrl { get; set; }
        public string SubscribleCount { get; set; }
        public string VideoCount { get; set; }

        public int GetSubscribleCount()
        {
            throw new NotImplementedException();
        }

        public int GetVideoCount()
        {
            throw new NotImplementedException();
        }
    }
}

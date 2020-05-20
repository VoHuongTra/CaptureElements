using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class FullScreenAd : BaseElement
    {
        public bool? IsSkipable { get; set; }
        public Button LearnMoreBtn { get; set; }
        public Button SkipAdBtn { get; set; }
        public string RemainingTime { get; set; }
    }
}

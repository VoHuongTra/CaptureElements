
using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Commons
{
    public class Video : BaseElement
    {
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public Channel Channel { get; set; }
        public string VideoDuration { get; set; }
        public string ViewCount { get; set; }
        public string UploadTime { get; set; }
    }
}

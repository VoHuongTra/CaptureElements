using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageHome
{
    public class PageHome : BaseElement
    {
        public List<Video> Videos { get; set; }
        public List<Post> Posts { get; set; }
    }
}

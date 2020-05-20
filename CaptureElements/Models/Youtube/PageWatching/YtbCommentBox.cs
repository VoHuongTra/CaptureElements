using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class YtbCommentBox : BaseElement
    {
        public bool? IsShowed { get; set; }
        public TextBox TxtComment { get; set; }
        public Button SubmitBtn { get; set; }
        public Button CancelBtn { get; set; }
    }
}

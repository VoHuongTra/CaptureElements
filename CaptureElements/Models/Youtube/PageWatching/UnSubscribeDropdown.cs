using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class UnSubscribeDropdown : BaseElement
    {
        public bool? IsShowed { get; set; }
        public Button CancelBtn { get; set; }
        public Button ConfirmBtn { get; set; }
    }
}

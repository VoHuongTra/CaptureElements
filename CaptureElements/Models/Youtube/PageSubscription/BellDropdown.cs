using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageSubscription
{
    public class BellDropdown : BaseElement
    {
        public Button All { get; set; }
        public Button Personalised { get; set; }
        public Button None { get; set; }
    }
}

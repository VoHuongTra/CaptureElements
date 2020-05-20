using CaptureElements.Models.Google.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Elements
{
    public class Button: BaseElement
    {
        public string Title { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsSelected { get; set; }
        public string Url { get; set; }
    }
}

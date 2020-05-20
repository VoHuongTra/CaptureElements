using CaptureElements.Models.Google.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Elements
{
    public class TextBox : BaseElement
    {
        public string Text { get; set; }
        public bool? IsFocused { get; set; }
    }
}
